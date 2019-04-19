using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;

namespace App1.ViewModels
{
    public class FirstViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "First";

        public IScreen HostScreen { get; }

        public ReactiveCommand<Unit, IRoutableViewModel> GoToSecondPage { get; }

        public FirstViewModel(IScreen hostScreen)
        {
            HostScreen = hostScreen;

            GoToSecondPage = ReactiveCommand.CreateFromObservable(() => HostScreen.Router.Navigate.Execute(new SecondViewModel(HostScreen)));
        }
    }
}
