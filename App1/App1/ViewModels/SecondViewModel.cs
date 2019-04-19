using ReactiveUI;

namespace App1.ViewModels
{
    public class SecondViewModel: ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "Second";
        public IScreen HostScreen { get; }

        public SecondViewModel(IScreen hostScreen)
        {
            HostScreen = hostScreen;
        }
    }
}
