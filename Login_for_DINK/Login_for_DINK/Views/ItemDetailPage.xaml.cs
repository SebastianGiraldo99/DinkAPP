using System.ComponentModel;
using Xamarin.Forms;
using Login_for_DINK.ViewModels;

namespace Login_for_DINK.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}