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
using System.Security.Cryptography;

namespace PCComp
{
    class Avtoris
    {

        static PCCOMPANYEntities db = new PCCOMPANYEntities();
        static public void Autorisation(TextBox tbLog, PasswordBox pbPassw, Window MainWindow)
        {
            if (String.IsNullOrEmpty(tbLog.Text) || String.IsNullOrEmpty(pbPassw.Password))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

               
                authorisation usr = db.authorisation.SingleOrDefault(c => c.Login == tbLog.Text);
                if (usr == null)
                {
                    MessageBox.Show("Такого пользователя не существует");
                    return;
                }
                Func f = new Func();
                if (f.CheckPassword(usr.Password, f.GetHashPassword(pbPassw.Password)))
                {
                    MessageBox.Show("Здравствуйте");
                    reporord reporord = new reporord();
                    reporord.Show();
                    MainWindow.Hide();
                }
                else
                {
                    MessageBox.Show("Пароль неверный!");
                }

            }
        }

    }
        }
