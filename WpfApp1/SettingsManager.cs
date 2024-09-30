//using System;

//namespace 一言.Services
//{
//    public class SettingsManager
//    {
//        private static SettingsManager? _instance;
//        private static readonly object _lock = new object();

//        // 存储语言和主题的属性
//        public string CurrentLanguage { get; private set; }
//        public string CurrentTheme { get; private set; }

//        //// 私有构造函数，确保外部无法实例化
//        //private SettingsManager()
//        //{
//        //    // 默认语言和主题
//        //    CurrentLanguage = "zh-CN";
//        //    CurrentTheme = "Light";
//        //}

//        // 获取单例实例
//        public static SettingsManager Instance
//        {
//            get
//            {
//                lock (_lock)
//                {
//                    if (_instance == null)
//                    {
//                        _instance = new SettingsManager();
//                    }
//                    return _instance;
//                }
//            }
//        }

//        // 更改语言
//        public void ChangeLanguage(string newLanguage)
//        {
//            CurrentLanguage = newLanguage;
//            Console.WriteLine($"Language changed to: {newLanguage}");
//        }

//        // 更改主题
//        public void ChangeTheme(string newTheme)
//        {
//            CurrentTheme = newTheme;
//            Console.WriteLine($"Theme changed to: {newTheme}");
//        }
//    }
//}
