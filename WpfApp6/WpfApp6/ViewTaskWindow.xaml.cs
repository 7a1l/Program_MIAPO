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
    /// Логика взаимодействия для ViewTaskWindow.xaml
    /// </summary>
    public partial class ViewTaskWindow : Window
    {
        private Task task;
        public ViewTaskWindow(Task task)
        {
            InitializeComponent();
            this.task = task;

            // Загрузка данных задачи
            TaskNameTextBlock.Text = task.Name;
            TaskDescriptionTextBlock.Text = task.Description;
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрытие окна
            Close();
        }
    }
}
