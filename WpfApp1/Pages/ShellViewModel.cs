using System;
using Stylet;

namespace 一言.Pages
{
    public class ShellViewModel : Screen
    {
        public void SwitchToEng()
        {
            WPFLocalizeExtension.Engine.LocalizeDictionary.Instance.Culture =
                System.Globalization.CultureInfo.GetCultureInfo("en-US");
        }

        public void SwitchToCn()
        {
            WPFLocalizeExtension.Engine.LocalizeDictionary.Instance.Culture =
                System.Globalization.CultureInfo.GetCultureInfo("zh-CN");
        }

        public void SwitchToRu()
        {
            WPFLocalizeExtension.Engine.LocalizeDictionary.Instance.Culture =
                System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
        }


    }
}
//public void ChangeLanguage(string languageCode)
//{
//    switch (languageCode)
//    {
//        case "zh-CN":
//            SwitchToCn();
//            break;
//        case "en-US":
//            SwitchToEng();
//            break;
//        case "ru-RU":
//            SwitchToCn1();
//            break;
//        default:
//            throw new ArgumentException("Unsupported language code");
//    }
//}
