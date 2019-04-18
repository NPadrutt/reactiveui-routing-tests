using System.Reactive;
using App1.UWP.Views;
using App1.ViewModels;
using ReactiveUI;
using Splat;

namespace App1.UWP
{
    public class Bootstrapper : ReactiveObject, IScreen
    {
        public Bootstrapper()
        {
            //Akavache.BlobCache.ApplicationName = "Camelotia";
            Router = new RoutingState();
            RegisterParts(Locator.CurrentMutable);

            Router.Navigate.Execute(new FirstViewModel(this));

            GoNext = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new FirstViewModel(this)));

            // You can also ask the router to go back.
            GoBack = Router.NavigateBack;
        }



        // The command that navigates a user to first view model.
        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }

        // The command that navigates a user back.
        public ReactiveCommand<Unit, Unit> GoBack { get; }

        public RoutingState Router { get; private set; }

        private void RegisterParts(IMutableDependencyResolver dependencyResolver)
        {
            dependencyResolver.RegisterConstant(this, typeof(IScreen));

            dependencyResolver.Register(() => new FirstView(), typeof(IViewFor<FirstViewModel>));
            dependencyResolver.Register(() => new SecondView(), typeof(IViewFor<SecondViewModel>));
        }
    }
}
