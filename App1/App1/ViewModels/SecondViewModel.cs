using System.ComponentModel;
using ReactiveUI;
using PropertyChangingEventArgs = ReactiveUI.PropertyChangingEventArgs;
using PropertyChangingEventHandler = ReactiveUI.PropertyChangingEventHandler;

namespace App1.ViewModels
{
    public class SecondViewModel: IRoutableViewModel
    {
        public string UrlPathSegment => "Second";
        public IScreen HostScreen { get; }

        public SecondViewModel(IScreen hostScreen)
        {
            HostScreen = hostScreen;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
        public void RaisePropertyChanging(PropertyChangingEventArgs args)
        {
        }

        public void RaisePropertyChanged(PropertyChangedEventArgs args)
        {
        }
    }
}
