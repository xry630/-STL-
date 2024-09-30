using System;  // 引入系统命名空间
using System.Net.Http;  // 引入用于处理 HTTP 请求和响应的命名空间
using System.Threading.Tasks;  // 引入异步编程所需的命名空间
using Newtonsoft.Json;  // 引入用于处理 JSON 的命名空间
using System.Threading;  // 引入用于处理取消操作的命名空间
using 一言.Models;  // 引入我们之前定义的模型命名空间

namespace 一言.Services  // 定义服务命名空间，便于组织与 API 调用相关的代码
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;  // HttpClient 实例，用于发起 HTTP 请求
        private readonly TimeSpan _timeout = TimeSpan.FromSeconds(5);  // 设置一个超时时间，避免长时间等待

        public ApiService()
        {
            _httpClient = new HttpClient { Timeout = _timeout };  // 初始化 HttpClient 实例并设置超时
        }

        // 异步方法，用于获取诗句
        public async Task<string> GetPoem(CancellationToken cancellationToken = default)
        {
            const string url = "http://www.sblt.deali.cn:15911/poem/simple";  // 诗句 API 的 URL
            try
            {
                using (var response = await _httpClient.GetAsync(url, cancellationToken))  // 发起 GET 请求
                {
                    response.EnsureSuccessStatusCode();  // 确保请求成功
                    return await response.Content.ReadAsStringAsync();  // 读取响应内容
                }
            }
            catch (TaskCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                return "(请求取消)";  // 在请求被取消时返回
            }
            catch (Exception)
            {
                return "(无网络)";  // 在发生错误时返回错误消息
            }
        }

        // 异步方法，用于获取“一言”
        public async Task<string> GetHitokoto(CancellationToken cancellationToken = default)
        {
            const string url = "http://www.sblt.deali.cn:15911/hitokoto/get";  // 一言 API 的 URL
            try
            {
                using (var response = await _httpClient.GetAsync(url, cancellationToken))  // 发起 GET 请求
                {
                    response.EnsureSuccessStatusCode();  // 确保请求成功
                    var json = await response.Content.ReadAsStringAsync();  // 读取响应内容
                    var obj = JsonConvert.DeserializeObject<HitokotoResponse>(json);  // 反序列化 JSON 响应
                    return obj?.Data?.Count > 0 ? obj.Data[0].Hitokoto : "(未能获取一言)";  // 检查数据并返回
                }
            }
            catch (TaskCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                return "(请求取消)";  // 在请求被取消时返回
            }
            catch (Exception)
            {
                return "(无网络)";  // 在发生错误时返回错误消息
            }
        }
    }
}

