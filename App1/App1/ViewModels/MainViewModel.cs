using ReactiveUI;

namespace App1.ViewModels
{
    public class MainViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "First";

        public IScreen HostScreen { get; }

        public FirstViewModel FirstViewModel { get; set; }

        public MainViewModel(IScreen hostScreen) {
            HostScreen = hostScreen;
        }
    }
}
