using System.Collections.ObjectModel;

namespace MauiProject1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection <string> Items { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PleaseHolder.Text))
            {
                Items.Add(PleaseHolder.Text);
                PleaseHolder.Text = string.Empty;
            }

        }
    }

}
