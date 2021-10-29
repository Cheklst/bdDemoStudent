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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bdDemoStudent.View
{
    public partial class PageUser : Page
    {
        WinMain pw;
        public PageUser(WinMain winMain)
        {
            InitializeComponent();
            pw = winMain;
        }
        private void LoadGrid(object sender, RoutedEventArgs e)
        {
            if (pw.Check_1.IsChecked == true)
            {
                Name1.Visibility = Visibility.Visible;
                Fam.Visibility = Visibility.Visible;
            }
            else
            {
                Name1.Visibility = Visibility.Collapsed;
                Fam.Visibility = Visibility.Collapsed;
            }
            if (pw.Check_2.IsChecked == true)
            {
                Name2.Visibility = Visibility.Visible;
                Im.Visibility = Visibility.Visible;
            }
            else
            {
                Name2.Visibility = Visibility.Collapsed;
                Im.Visibility = Visibility.Collapsed;
            }
            if (pw.Check_3.IsChecked == true)
            {
                GroupSearch.Visibility = Visibility.Visible;
                gro.Visibility = Visibility.Visible;
            }
            else
            {
                GroupSearch.Visibility = Visibility.Collapsed;
                gro.Visibility = Visibility.Collapsed;
            }
            GridMain.ItemsSource = Helper.demoBd.Users.ToList();
            if (pw.Check2_1.IsChecked == true)
            {
                Group.Visibility = Visibility.Visible;
            }
            else
            {
                Group.Visibility = Visibility.Collapsed;
            }
            if (pw.Check2_2.IsChecked == true)
            {
                N1.Visibility = Visibility.Visible;
            }
            else
            {
                N1.Visibility = Visibility.Collapsed;
            }
            if (pw.Check2_3.IsChecked == true)
            {
                N2.Visibility = Visibility.Visible;
            }
            else
            {
                N2.Visibility = Visibility.Collapsed;
            }
            if (pw.Check2_4.IsChecked == true)
            {
                N3.Visibility = Visibility.Visible;
            }
            else
            {
                N3.Visibility = Visibility.Collapsed;
            }
            if (pw.Check2_5.IsChecked == true)
            {
                Year.Visibility = Visibility.Visible;
            }
            else
            {
                Year.Visibility = Visibility.Collapsed;
            }
            if (pw.Check2_6.IsChecked == true)
            {
                MobTel.Visibility = Visibility.Visible;
            }
            else
            {
                MobTel.Visibility = Visibility.Collapsed;
            }
            if (pw.Check2_7.IsChecked == true)
            {
                HomeTel.Visibility = Visibility.Visible;
            }
            else
            {
                HomeTel.Visibility = Visibility.Collapsed;
            }
            if (pw.Check2_8.IsChecked == true)
            {
                Mail.Visibility = Visibility.Visible;
            }
            else
            {
                Mail.Visibility = Visibility.Collapsed;
            }
            if (pw.Check2_9.IsChecked == true)
            {
                Country.Visibility = Visibility.Visible;
            }
            else
            {
                Country.Visibility = Visibility.Collapsed;
            }
            var hh = Helper.demoBd.Groups;
            GridMain.ItemsSource = Helper.demoBd.Users.ToList();
            GroupSearch.DataContext = hh;
            GroupSearch.ItemsSource = hh.ToList();
        }
        private void ResetSearch(object sender, RoutedEventArgs e)
        {
            GroupSearch.SelectedIndex = -1;
            Name1.Text = null;
            Name2.Text = null;
            GridMain.ItemsSource = Helper.demoBd.Users.ToList();
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Name1.Text) && string.IsNullOrEmpty(Name2.Text) && GroupSearch.SelectedIndex == -1)
            {
                return;
            }
            if (GroupSearch.SelectedIndex == -1)
            {
                GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.Name1.Contains(Name1.Text) &&
                                                               i.Name2.Contains(Name2.Text)).ToList();
            }
            else
            {
                GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.Name1.Contains(Name1.Text) &&
                                                               i.Name2.Contains(Name2.Text) &&
                                                               i.IdGroup == (int)GroupSearch.SelectedValue).ToList();
            }
        }
    }
}
