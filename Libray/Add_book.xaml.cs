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
    /// Логика взаимодействия для Add_book.xaml
    /// </summary>
    public partial class Add_book : Page
    {
        private Book currentBook = new Book();

        public Add_book(Book selectedBook)
        {
            InitializeComponent();

            if (selectedBook !=null)
                currentBook = selectedBook;

            DataContext = currentBook;
        }

        private void Button_save(object sender, RoutedEventArgs e) //созранение книги
        {
            StringBuilder errors = new StringBuilder();


            if (currentBook.Cipher < 1) //проверка на нименование
            {
                errors.AppendLine("Укажите шифр книги");
            }
            if (string.IsNullOrWhiteSpace(currentBook.Name_book)) //проверка на нименование
            {
                errors.AppendLine("Укажите наименование книги");
            }
            if (string.IsNullOrWhiteSpace(currentBook.Author)) //проверка на автора
            {
                errors.AppendLine("Укажите автора");
            }
            if (string.IsNullOrWhiteSpace(currentBook.Genre)) //проверка на жанр
            {
                errors.AppendLine("Укажите жанр");
            }
            if (currentBook.Number_of_pages < 1) //проверка на количетсво страниц
            {
                errors.AppendLine("Укажите количество страниц");
            }

            if (errors.Length > 0) //вывод ошибок пользователя
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (currentBook.ID == 0) //сохранение
                Libray_bookEntities.GetContext().Books.Add(currentBook);
        
            try
            {
                Libray_bookEntities.GetContext().SaveChanges();
                MessageBox.Show("Книга сохранена!");
                Manager.Main_frame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }            
        }

        private void Button_cancel(object sender, RoutedEventArgs e) //отмена созранения книги
        {
            Manager.Main_frame.GoBack();
        } 
    }
}
