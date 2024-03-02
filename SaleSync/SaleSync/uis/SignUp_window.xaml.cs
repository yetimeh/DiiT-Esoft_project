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
		public SignUp_window()
		{
			InitializeComponent();
		}

		private void firstname_MouseDown(object sender, MouseButtonEventArgs e)
		{
			FName.Focus();
		}

		private void FName_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(FName.Text) && FName.Text.Length > 0)
			{
				firstname.Visibility = Visibility.Collapsed;
			}
			else
			{
				firstname.Visibility = Visibility.Visible;
			}
		}

		private void lastname_MouseDown(object sender, MouseButtonEventArgs e)
		{
			LName.Focus();
		}

		private void LName_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(LName.Text) && LName.Text.Length > 0)
			{
				lastname.Visibility = Visibility.Collapsed;
			}
			else
			{
				lastname.Visibility = Visibility.Visible;
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

		private void locationtext_MouseDown(object sender, MouseButtonEventArgs e)
		{
			locationpin.Focus();
		}

		private void locationpin_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(locationpin.Text) && locationpin.Text.Length > 0)
			{
				locationtext.Visibility = Visibility.Collapsed;
			}
			else
			{
				locationtext.Visibility = Visibility.Visible;
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{

        }

        private void update_pro_pic(object sender, RoutedEventArgs e)
        {

        }

		private void cancel_click (object sender, RoutedEventArgs e)
        {

        }

        private void register_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
