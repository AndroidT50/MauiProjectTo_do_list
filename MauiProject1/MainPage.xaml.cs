using System.Collections.ObjectModel;

namespace MauiProject1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection <string> Items { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

}
