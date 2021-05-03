using Pusle_mobiilirakendus.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Pusle_mobiilirakendus.Views
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