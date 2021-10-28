using bdDemoStudent.Class;
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

namespace bdDemoStudent.View
{
    public partial class WinMain : Window
    {
        public enum pageDemo
        { 
            PageAdmin = 1,
            PageUser
        }
        public WinMain()
        {
            InitializeComponent();
            WinLogin winLogin = new WinLogin();
            winLogin.ShowDialog();
            try
            {
                switch (Helper.users.Roles.Id)
                {
                    case (int)pageDemo.PageAdmin:
                        MessageBox.Show("Администратор", "Выбор",
                            MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    case (int)pageDemo.PageUser:
                        MessageBox.Show("Пользователь", "Выбор", MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                        break;
                }
            }
            catch
            {
                Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Helper.ActiveAdd();
            Application.Current.Shutdown();
        }
    }
}
