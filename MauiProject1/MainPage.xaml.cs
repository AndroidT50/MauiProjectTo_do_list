using Network;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiProject1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection <string> Items { get; set; } = new ObservableCollection<string>();
        public ICommand DeleteTaskCommand { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PleaseHolder.Text))
            {
                //Items.Add(PleaseHolder.Text);
                Items.Insert(0, PleaseHolder.Text);
                PleaseHolder.Text = string.Empty;
            }

        }

        DeleteTaskCommand = new Command <string>(DeleteTask);
        private void DeleteTask(string task)
        {
            //Items.Clear();
            Items.Remove(task);
        }
    }

}
