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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();

            DGridBook.ItemsSource = Libray_bookEntities.GetContext().Books.ToList();
        }

        private void Button_edit(object sender, RoutedEventArgs e) //кнопка редактирования
        {
            Manager.Main_frame.Navigate(new Add_book((sender as Button).DataContext as Book));

            DGridBook.ItemsSource = Libray_bookEntities.GetContext().Books.ToList();
        }

        private void Button_delete(object sender, RoutedEventArgs e) //удаление книги
        {
            var book = DGridBook.SelectedItems.Cast<Book>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить столько {book.Count()} книг", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Libray_bookEntities.GetContext().Books.RemoveRange(book);
                    Libray_bookEntities.GetContext().SaveChanges();
                    MessageBox.Show("Книга удалены");

                    DGridBook.ItemsSource = Libray_bookEntities.GetContext().Books.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
