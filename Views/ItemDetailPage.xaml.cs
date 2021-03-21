using OCC.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace OCC.Views
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