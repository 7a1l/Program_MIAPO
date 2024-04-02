﻿using System.Text;
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
        }

        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ViewTaskButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void SearchTaskButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}