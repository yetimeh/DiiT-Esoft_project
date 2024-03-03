using esoftprojecttest.utils;
using SaleSync.uis;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace esoftprojecttest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class Login_window : Window
	{
		private DatabaseAPI database = new DatabaseAPI();

		public Login_window()
		{
			InitializeComponent();
		}

		private void textID_MouseDown(object sender, MouseButtonEventArgs e)
		{
			txtID.Focus();
		}

		private void txtID_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(txtID.Text) && txtID.Text.Length > 0)
			{
				textID.Visibility = Visibility.Collapsed;
			}
			else 
			{
				textID.Visibility = Visibility.Visible;
			}
		}

		private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
		{
			txtPassword.Focus();
		}

		private  void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
			{
				textPassword.Visibility = Visibility.Collapsed;
			}
			else
			{
				textPassword.Visibility = Visibility.Visible;
			}
		}


		private void Image_MouseUp(object sender, MouseButtonEventArgs e)
		{
			Application.Current.Shutdown();
		}

	

        private void Login_Click(object sender, RoutedEventArgs e)
        {
			var login = database.login(txtID.Text, txtPassword.Password);

			if (login == null)
			{
				MessageBox.Show("You haven't created an account yet or the credentials you entered are wrong! Click the sign up button if you want to create an account.", "Error :(", MessageBoxButton.OK);
				return;
			}

			this.Hide();
			if (login["admin"] == true)
			{
				Dashbord_Screen admin = new Dashbord_Screen(user: login);
				admin.Show();
			} else
			{
				cashier_dashbord cashier_Dashbord = new cashier_dashbord(user: login);
				cashier_Dashbord.Show();
			}

			
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
			this.Hide(); // Hide sign in screen
			SignUp_window signUpWindow = new SignUp_window();

			signUpWindow.Show();
        }
    }

}