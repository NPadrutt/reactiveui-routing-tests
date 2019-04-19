using App1.ViewModels;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondView : ContentPage, IViewFor<SecondViewModel>
    {
        public SecondView() {
            InitializeComponent();
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (SecondViewModel)value;
        }

        public SecondViewModel ViewModel { get; set; }
    }
}