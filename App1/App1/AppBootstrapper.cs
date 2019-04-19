using App1.Pages;
using App1.ViewModels;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using Xamarin.Forms;

namespace App1
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public AppBootstrapper(IMutableDependencyResolver dependencyResolver = null, RoutingState router = null)
        {

            Router = router ?? new RoutingState();

            RegisterParts(dependencyResolver ?? Locator.CurrentMutable);

            Router.Navigate.Execute(new MainViewModel(this));
        }

        public RoutingState Router { get; private set; }

        private void RegisterParts(IMutableDependencyResolver dependencyResolver)
        {
            dependencyResolver.RegisterConstant(this, typeof(IScreen));

            dependencyResolver.Register(() => new MainPage(), typeof(IViewFor<MainViewModel>));
            dependencyResolver.Register(() => new FirstView(), typeof(IViewFor<FirstViewModel>));
            dependencyResolver.Register(() => new SecondView(), typeof(IViewFor<SecondViewModel>));


            dependencyResolver.Register(() => new FirstViewModel(this), typeof(FirstViewModel));
        }

        public Page CreateMainPage()
        {
            return new RoutedViewHost();
        }
    }
}