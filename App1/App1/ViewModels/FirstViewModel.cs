using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using PropertyChangingEventArgs = ReactiveUI.PropertyChangingEventArgs;
using PropertyChangingEventHandler = ReactiveUI.PropertyChangingEventHandler;

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

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
        public void RaisePropertyChanging(PropertyChangingEventArgs args)
        {
            throw new System.NotImplementedException();
        }

        public void RaisePropertyChanged(PropertyChangedEventArgs args)
        {
            throw new System.NotImplementedException();
        }
    }
}
