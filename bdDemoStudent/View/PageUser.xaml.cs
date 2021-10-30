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
            GodSearch.ItemsSource = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1);
            var hh = Helper.demoBd.Groups;
            GridMain.ItemsSource = Helper.demoBd.Users.ToList();
            GroupSearch.DataContext = hh;
            GroupSearch.ItemsSource = hh.ToList();

            if (pw.Check_1.IsChecked == false && pw.Check_2.IsChecked == false && pw.Check_3.IsChecked == false)
                GR_BOX.Visibility = Visibility.Collapsed;
            else
                GR_BOX.Visibility = Visibility.Visible;

            if (pw.Check_1.IsChecked == true)
                FamSearch.Visibility = Visibility.Visible;
            else
                FamSearch.Visibility = Visibility.Collapsed;


            if (pw.Check_2.IsChecked == true)
                GoddSearch.Visibility = Visibility.Visible;
            else
                GoddSearch.Visibility = Visibility.Collapsed;


            if (pw.Check_3.IsChecked == true)
                GrSearch.Visibility = Visibility.Visible;
            else
                GrSearch.Visibility = Visibility.Collapsed;

        }
        private void ResetSearch(object sender, RoutedEventArgs e)
        {
            GroupSearch.SelectedIndex = -1;
            GodSearch.SelectedIndex = -1;
            Name1.Text = null;
            GridMain.ItemsSource = Helper.demoBd.Users.ToList();
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Name1.Text) && GodSearch.SelectedIndex == -1 && GroupSearch.SelectedIndex == -1)
                return;
            if (string.IsNullOrEmpty(Name1.Text))
            {
                if (GodSearch.SelectedIndex != -1 && GroupSearch.SelectedIndex != -1)
                {
                    GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.IdGroup == (int)GroupSearch.SelectedValue && i.DateOfReceipt == (int)GodSearch.SelectedValue).ToList();
                }
                else
                {
                    if (GodSearch.SelectedIndex == -1)
                    {
                        GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.IdGroup == (int)GroupSearch.SelectedValue).ToList();
                    }
                    else
                    {
                        GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.DateOfReceipt == (int)GodSearch.SelectedValue).ToList();
                    }
                }
            }
            else
            {
                if (GodSearch.SelectedIndex != -1 && GroupSearch.SelectedIndex != -1)
                {
                    GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.Name1.Contains(Name1.Text) &&
                    i.IdGroup == (int)GroupSearch.SelectedValue &&
                    i.DateOfReceipt == (int)GodSearch.SelectedValue).ToList();
                }
                else
                {
                    if (GodSearch.SelectedIndex == -1 && GroupSearch.SelectedIndex == -1)
                    {
                        GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.Name1.Contains(Name1.Text)).ToList();
                    }
                    else
                    {
                        if (GroupSearch.SelectedIndex != -1)
                        {
                            GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.Name1.Contains(Name1.Text) &&
                            i.IdGroup == (int)GroupSearch.SelectedValue).ToList();
                        }
                        else
                        {
                            GridMain.ItemsSource = Helper.demoBd.Users.Where(i => i.Name1.Contains(Name1.Text) && 
                            i.DateOfReceipt == (int)GodSearch.SelectedValue).ToList();
                        }
                    }
                }
            }
        }
    }
}
