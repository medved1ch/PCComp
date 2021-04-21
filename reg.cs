using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace PCComp
{
    class reg
    {
        static PCCOMPANYEntities db = new PCCOMPANYEntities();
        static public void regist(TextBox tbFN, TextBox tbLN, TextBox tbLog, PasswordBox pbPassw,  Window registration)
        {
            if (String.IsNullOrEmpty(tbLog.Text) || String.IsNullOrEmpty(pbPassw.Password))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            
            
        }
    }
}
