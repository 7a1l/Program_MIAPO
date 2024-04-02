using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public List<Task> tasks = new List<Task>();

        public MainWindow()
        {
            InitializeComponent();
           
           UpdateTasksList();
        }
        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        public void UpdateTasksList()
        {
        }

        private void EditTaskButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ViewTaskButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void SearchTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var filteredTasks = tasks.Where(task => task.Name.Contains(SearchTextBox.Text) || task.Description.Contains(SearchTextBox.Text));
            TasksListBox.Items.Clear();
            foreach (var task1 in filteredTasks)
            {
                TasksListBox.Items.Add(task1);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}