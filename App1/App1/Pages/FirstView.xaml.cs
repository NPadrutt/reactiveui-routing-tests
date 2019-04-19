using System.Reactive.Disposables;
using App1.ViewModels;
using ReactiveUI;
using Splat;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstView :  IViewFor<FirstViewModel>
    {
        public FirstView() {
            InitializeComponent();

            if (ViewModel == null)
            {
                ViewModel = Locator.Current.GetService<FirstViewModel>();
            }

            this.WhenActivated(disposables => {
                this.BindCommand(ViewModel, x => x.GoToSecondPage, x => x.NavigationButton)
                    .DisposeWith(disposables);
            });
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (FirstViewModel)value;
        }

        public FirstViewModel ViewModel { get; set; }
    }
}