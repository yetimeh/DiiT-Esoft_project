using esoftprojecttest.utils;
using Microsoft.Win32;
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
using static System.Net.Mime.MediaTypeNames;


namespace esoftprojecttest
{
	/// <summary>
	/// Interaction logic for Page1.xaml
	/// </summary>
	public partial class SignUp_window: Window
	{

		private DatabaseAPI database = new DatabaseAPI();
		private bool is_admin;
		public SignUp_window(bool is_admin = false)
		{
            this.is_admin = is_admin;
			InitializeComponent();
		}

		


		private void fullname_MouseDown(object sender, MouseButtonEventArgs e)
		{
			FName.Focus();
		}

        

        private void FName_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(FName.Text) && FName.Text.Length > 0)
			{
				fullname.Visibility = Visibility.Collapsed;
			}
			else
			{
				fullname.Visibility = Visibility.Visible;
			}
		}

		private void password_text_MouseDown(object sender, MouseButtonEventArgs e)
		{
			password_txt.Focus();
		}

		private void password_txt_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(password_text.Text) && password_text.Text.Length > 0)
			{
				password_text.Visibility = Visibility.Collapsed;
			}
			else { 
				password_text.Visibility = Visibility.Visible;
			}
		}

		private void NIC_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Ncard.Focus();
		}

		private void Ncard_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(Ncard.Text) && Ncard.Text.Length > 0)
			{
				NIC.Visibility = Visibility.Collapsed;
			}
			else
			{
				NIC.Visibility = Visibility.Visible;
			}
		}

		private void username_MouseDown(object sender, MouseButtonEventArgs e)
		{
			uname.Focus();
		}

		private void uname_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(uname.Text) && uname.Text.Length > 0)
			{
				username.Visibility = Visibility.Collapsed;
			}
			else
			{
				username.Visibility = Visibility.Visible;
			}
		}

		private void phone_number_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Pnumber.Focus();
		}

		private void Pnumber_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(Pnumber.Text) && Pnumber.Text.Length > 0)
			{
				phone_number.Visibility = Visibility.Collapsed;
			}
			else
			{
				phone_number.Visibility = Visibility.Visible;
			}

		}

		private string imageSource;

        private void update_pro_pic(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png)|*.png";

			openFileDialog.ShowDialog();
			imageSource = openFileDialog.FileName;

			proPic.Source = new BitmapImage(new Uri($"{openFileDialog.FileName}", UriKind.Absolute)); // update UI image




        }

		private void cancel_click(object sender, RoutedEventArgs e)
		{
			this.Hide();
			Login_window login_window = new Login_window();

			login_window.Show();
		}

        private void register_click(object sender, RoutedEventArgs e)
        {
			bool result = database.create_user(
					username: uname.Text,
					password: password_txt.Text,
					fullname: FName.Text,
					nic: Ncard.Text,
					phoneNumber: Pnumber.Text,
					imagePath: imageSource,
					admin: is_admin == true ? "yes" : "no"

			); 

			if (result == true)
			{
				this.Hide();
				Login_window login = new Login_window();

				login.Show();
			}
        }

        



    }
}
