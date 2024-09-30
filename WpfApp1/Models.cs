using System;  // 引入系统命名空间，提供基本类型和基类支持
using System.Collections.Generic;  // 引入集合泛型命名空间，用于处理列表等集合类型

namespace 一言.Models  // 定义一个命名空间，便于组织代码
{
    // 定义 Hitokoto 类，表示“一言”的数据结构
    public class Hitokoto1
    {
        public long Id { get; set; }  // 一言的唯一标识符
        public string Hitokoto { get; set; }  // 一言的内容
        public string Type { get; set; }  // 一言的类型
        public string FromWhere { get; set; }  // 一言的出处
        public string Creator { get; set; }  // 一言的创建者
        public DateTime CreatedAt { get; set; }  // 一言的创建时间
    }

    // 定义 HitokotoResponse 类，表示从 API 返回的 JSON 响应
    public class HitokotoResponse
    {
        public string Status { get; set; }  // 响应的状态，如 "success" 或 "error"
        public string Msg { get; set; }  // 返回的信息或消息
        public List<Hitokoto1> Data { get; set; }  // 包含多个一言的列表
    }
}

