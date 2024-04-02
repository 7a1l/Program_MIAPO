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
            var addTaskWindow = new AddTaskWindow();
            if (addTaskWindow.ShowDialog() == true)
            {
                var task = new Task(addTaskWindow.TaskNameTextBox.Text, addTaskWindow.TaskDescriptionTextBox.Text);
                tasks.Add(task);

                UpdateTasksList();
            }
        }

        public void UpdateTasksList()
        {
            if (tasks.Count > 0)
            {
                EditTaskButton.IsEnabled = true;
                DeleteTaskButton.IsEnabled = true;
                ViewTaskButton.IsEnabled = true;
            }
            else
            {
                EditTaskButton.IsEnabled = false;
                DeleteTaskButton.IsEnabled = false;
                ViewTaskButton.IsEnabled = false;

            }
            TasksListBox.Items.Clear();
            foreach (var task in tasks)
            {
                TasksListBox.Items.Add(task);
            }
        }

        private void EditTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = TasksListBox.SelectedItem as Task;

            if (selectedTask != null)
            {
                var editTaskWindow = new EditTaskWindow(selectedTask);
                if (editTaskWindow.ShowDialog() == true)
                {
                    selectedTask.Name = editTaskWindow.TaskNameTextBox.Text;
                    selectedTask.Description = editTaskWindow.TaskDescriptionTextBox.Text;
                    UpdateTasksList();
                }
            }
        }

        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = TasksListBox.SelectedItem as Task;
            if (selectedTask != null)
            {
                tasks.Remove(selectedTask);
                UpdateTasksList();
            }
        }

        private void ViewTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = TasksListBox.SelectedItem as Task;
            if (selectedTask != null)
            {
                var viewTaskWindow = new ViewTaskWindow(selectedTask);
                viewTaskWindow.ShowDialog();
            }
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