using System;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RxApp.SuspensionHost.CreateNewAppState = () => new AppBootstrapper();
            RxApp.SuspensionHost.SetupDefaultSuspendResume();

            MainPage = RxApp.SuspensionHost
                            .GetAppState<AppBootstrapper>()
                            .CreateMainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
