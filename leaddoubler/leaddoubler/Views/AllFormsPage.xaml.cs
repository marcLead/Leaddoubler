using leaddoubler.Models;
using leaddoubler.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace leaddoubler.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllFormsPage : ContentPage
    {
        public AllFormsPage()
        {
            InitializeComponent();
            BindingContext = new AllFormsViewModel { Navigation = Navigation };
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            (BindingContext as AllFormsViewModel).EditItem(e.Item as Values);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //btnAdd.IsEnabled = true;
        }

        /*private void Button_Clicked(object sender, EventArgs e)
        {
            btnAdd.IsEnabled = false;
        }*/

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            (BindingContext as AllFormsViewModel).AddClicked();
        }
    }
}