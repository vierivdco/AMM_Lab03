using Lab_03.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab_03.Views
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