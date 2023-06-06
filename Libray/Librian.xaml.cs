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
    /// Логика взаимодействия для Librian.xaml
    /// </summary>
    public partial class Librian : Page
    {
        public Librian()
        {
            InitializeComponent();

            DGridBook.ItemsSource = Libray_bookEntities.GetContext().Books.ToList();
        }

        private void Button_edit(object sender, RoutedEventArgs e) //добавление книги
        {
            Manager.Main_frame.Navigate(new Add_book(null));
        }

        private void Page_IsVisChanged(object sender, DependencyPropertyChangedEventArgs e) //обновление страницы при изменении
        {
            if (Visibility == Visibility.Visible)
            {
                Libray_bookEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridBook.ItemsSource = Libray_bookEntities.GetContext().Books.ToList();
            }
        }
    }
}
