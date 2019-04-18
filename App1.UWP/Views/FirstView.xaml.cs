using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App1.ViewModels;
using ReactiveUI;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FirstView : Page, IViewFor<FirstViewModel>
    {
        public FirstView()
        {
            this.InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.BindCommand(ViewModel, x => x.GoToSecondPage, x => x.FirstButton)
                    .DisposeWith(disposables);
            });
        }

        public FirstViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel =(FirstViewModel) value; }
        }
    }
}
