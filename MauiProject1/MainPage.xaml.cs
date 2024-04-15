
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace MauiProject1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection <TaskItem> Items { get; set; } = new ObservableCollection<TaskItem>();
       
        public ICommand DeleteCommand { get; private set; }
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            TaskCollectionView.BindingContext = this;
            DeleteCommand = new Command<TaskItem>(SwipeItem_Clicked);
            // Создание объекта с данными
        }
        public class TaskItem
        {
            public string?Task { get; set; }
            public DateTime Date { get; set; }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {    
            string taskName = PleaseHolder.Text.Trim();
            if (!string.IsNullOrEmpty(taskName))
            {
                Items.Add(new TaskItem { Task = taskName, Date = DateTime.Now });
                PleaseHolder.Text = string.Empty;
            }   
        }
        private void SwipeItem_Clicked(TaskItem task)
        {
            Items.Remove(task);
        }

       
    }

}
