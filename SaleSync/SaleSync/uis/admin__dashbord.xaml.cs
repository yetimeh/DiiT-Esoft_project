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
        public Dashbord_Screen()
        {
            InitializeComponent();
        }

		private void itemcode_text_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ICode_txt.Focus();
		}


		private void ICode_txt_textchanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(ICode_txt.Text) && ICode_txt.Text.Length > 0)
			{
				itemcode_text.Visibility = Visibility.Collapsed;
			}
			else
			{
				itemcode_text.Visibility = Visibility.Visible;
			}
		}

		//quantity
		private void quantity_text_MouseDown(object sender, MouseButtonEventArgs e)
		{
			quantity_txt.Focus();
		}

		private void quantity_txt_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(quantity_txt.Text) && quantity_txt.Text.Length > 0)
			{
				quantity_text.Visibility = Visibility.Collapsed;
			}
			else
			{
				quantity_text.Visibility = Visibility.Visible;
			}
		}
	}
}
