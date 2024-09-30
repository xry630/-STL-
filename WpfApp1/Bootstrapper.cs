using System;
using System.Windows.Threading;
using System.Windows;
using Stylet;
using StyletIoC;
using 一言.Pages;

namespace 一言
{
    public class Bootstrapper : Bootstrapper<ShellViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Configure the IoC container in here
        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
        }
    }


}



//public class Bootstrapper : Bootstrapper<ShellViewModel>
//{
//    protected override void OnStart()
//    {
//        // 在应用程序启动后，但在设置 IoC 容器之前调用此方法。
//        //设置日志记录等
//    }

//    protected override void ConfigureIoC(IStyletIoCBuilder builder)
//    {
//        //// 绑定你自己的类型。 具体类型是自动自绑定的。
//        //builder.Bind<IMyInterface>().To<MyType>();
//    }

//    protected override void Configure()
//    {
//        // 这在 Stylet 创建 IoC 容器之后调用，因此 this.Container 存在，但在
//        // 启动根 ViewModel。
//        // 在这里配置你的服务等
//    }

//    protected override void OnLaunch()
//    {
//        // 这是在根 ViewModel 启动后立即调用的
//        // 可能会从这里启动显示对话框的版本检查之类的东西
//    }

//    protected override void OnExit(ExitEventArgs e)
//    {
//        // 在 Application.Exit 上调用
//    }

//    protected override void OnUnhandledException(DispatcherUnhandledExceptionEventArgs e)
//    {
//        // 在 Application.DispatcherUnhandledException 上调用
//    }
//}
