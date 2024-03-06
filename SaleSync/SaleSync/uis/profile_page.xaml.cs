using esoftprojecttest;
using esoftprojecttest.utils;
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

namespace SaleSync.uis
{
    /// <summary>
    /// Interaction logic for profile_page.xaml
    /// </summary>
    public partial class profile_page : Window
    {
        private Dictionary<string, dynamic> user;

        public profile_page(Dictionary<string, dynamic> user)
        {
            this.user = user;
            InitializeComponent();

            user_name.Text = user["full_name"];
            user_nic.Text = user["nic"];
            user_phonenumber.Text = user["phone_number"];


            // Image Code

            //if (user["image_path"] != null || user["image_path"] != "")
            //{
            //    proPic.Source = new BitmapImage(new Uri(user["image_path"], UriKind.Absolute));
            //}
            //else

            //    MessageBox.Show("H");
            //{
            //    proPic.Source = new BitmapImage(new Uri("/Resources/profile.png", UriKind.Relative));
            //}

        }
        private void close_btn(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void logout(object sender, EventArgs e)
        {
            this.Hide();

            Login_window login = new Login_window();
            login.Show();
            
        }

        private void Back_btn(object sender, RoutedEventArgs e)
        {
            this.Hide();

            if (user["admin"] == true)
            {
                Dashbord_Screen admin = new Dashbord_Screen(user);
                admin.Show();
            } else
            {
                cashier_dashbord cashier = new cashier_dashbord(user);
                cashier.Show();
            }
        }
    }
}
