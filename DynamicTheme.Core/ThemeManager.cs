using System.Windows;

namespace DynamicTheme.Core // 定义命名空间
{
    public class ThemeManager // 定义公共类ThemeManager
    {
        // 创建一个字典来存储主题名称和对应的资源字典
        private Dictionary<string, ResourceDictionary> _themes = new();

        // 注册主题的方法
        public void RegisterTheme(string themeName, string assemblyName, string resourcePath)
        {
            // 构建资源URI
            string uri = $"/{assemblyName};component/{resourcePath}";

            // 创建新的资源字典
            ResourceDictionary resource = new ResourceDictionary();
            // 设置资源字典的来源
            resource.Source = new Uri(uri, UriKind.RelativeOrAbsolute);

            // 将主题名称和对应的资源字典添加到_themes字典中
            _themes.Add(themeName, resource);
        }

        // 应用主题的方法
        public void ApplyTheme(string themeName)
        {
            // 从_themes字典中获取指定名称的资源字典
            ResourceDictionary resource = _themes[themeName];

            // 将资源字典添加到应用程序的资源合并字典中
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }
    }
}