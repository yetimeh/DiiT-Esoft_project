using SaleSync.uis;
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

namespace esoftprojecttest
{
    /// <summary>
    /// Interaction logic for Dashbord_Screen.xaml
    /// </summary>
    public partial class Dashbord_Screen : Window
    {
        private Dictionary<string, dynamic> user;
        public Dashbord_Screen(Dictionary<string, dynamic> user )
        {
            this.user = user;
            InitializeComponent();


            welcome_text.Text = $"Welcome {(user != null ? user["full_name"] : "user")} to the Admin dashboard! You can click your desired action from the list on the left!";




        }


        private void close_img(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void admin_inventory_click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            inventory _inventory = new inventory(user);
            _inventory.Show();
        }

        private void admin_history_click(object sender, RoutedEventArgs e)
        {

            this.Hide();

            history _history = new history();
            _history.Show();

        }

        private void admin_my_profile_click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            profile_page profile = new profile_page(user);
            profile.Show();

        }

		private void admin_logout_click(object sender, RoutedEventArgs e)
		{
            this.Hide();

            Login_window login = new Login_window();
            login.Show();
		}

		private void admin_signup_click(object sender, RoutedEventArgs e)
		{
            this.Hide();

            SignUp_window signup = new SignUp_window(is_admin: true); // Set is_admin to true since we are creating an admin account
            signup.Show();
		}
      
    }
}
