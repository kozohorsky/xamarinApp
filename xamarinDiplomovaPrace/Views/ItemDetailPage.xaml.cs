using System.ComponentModel;
using Xamarin.Forms;
using xamarinDiplomovaPrace.ViewModels;

namespace xamarinDiplomovaPrace.Views
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