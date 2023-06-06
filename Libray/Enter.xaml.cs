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
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Page
    {
        public Enter()
        {
            InitializeComponent();

            //DataContext = currentUser;
        }

        private void Button_ent(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(Login_enter.Text.Trim())) //проверка логина
            {
                errors.AppendLine("Укажите свой логин");
            }
            if (string.IsNullOrEmpty(Password_enter.Password.Trim())) //проверка пароля
            {
                errors.AppendLine("Некоректный пароль");
            }

            if (errors.Length > 0) //вывод ошибок пользователя
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            using (var db = new Libray_bookEntities()) //сравнение с данными из БД
            {
                var user = db.Librarians.AsNoTracking().FirstOrDefault(u => u.Login == Login_enter.Text && u.Password == Password_enter.Password);

                if (user == null)
                {
                    MessageBox.Show("Такого пользователя несуществует");
                    return;
                }

                switch (user.Job) //вход на страницу пользователя, в зависимости от его роли
                {
                    case 2:
                        Manager.Main_frame.Navigate(new Librian());
                        break;
                    case 1:
                        Manager.Main_frame.Navigate(new Admin());
                        break;
                }
            }
        }
    }
}
