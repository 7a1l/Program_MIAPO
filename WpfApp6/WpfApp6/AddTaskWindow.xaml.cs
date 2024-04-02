using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        public AddTaskWindow()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TaskNameTextBox.Text))
            {
                MessageBox.Show("Введите название задачи.");
                return;
            }
            var task = new Task(TaskNameTextBox.Text, TaskDescriptionTextBox.Text);
            if (DialogResult == true)
            {
                var mainWindow = (MainWindow)Owner;
                mainWindow.tasks.Add(task);
                mainWindow.UpdateTasksList();
            }
            DialogResult = true;
            Close();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрытие окна и возврат DialogResult.False
            DialogResult = false;
            Close();
        }
    }
}
