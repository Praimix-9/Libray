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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Libray
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Main_menu.Navigate(new Enter());
            Manager.Main_frame = Main_menu;
        }


        private void Button_back(object sender, RoutedEventArgs e) //кнопка "Назад"
        {
            Manager.Main_frame.GoBack();
        }

        private void Main_frame_render(object sender, EventArgs e) //основной экран
        {
            if (Main_menu.CanGoBack)
            {
                Back_content.Visibility = Visibility.Visible;
            }
            else
            {
                Back_content.Visibility = Visibility.Hidden;
            }
        }
    }

    public partial class App : Application //сообщение при сбое
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Ты сломал программу: " + e.Exception.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }
}
