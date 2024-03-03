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
    /// Interaction logic for inventory.xaml
    /// </summary>
    public partial class inventory : Window
    {

		private DatabaseAPI database = new DatabaseAPI();
        public inventory()
        {
            InitializeComponent();
        }
        public void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

		
		//item code
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

		//item name
		private void itemname_text_MouseDown(object sender, MouseButtonEventArgs e)
		{
			IName_txt.Focus();
		}

		private void IName_txt_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(IName_txt.Text) && IName_txt.Text.Length > 0)
			{
				itemname_text.Visibility = Visibility.Collapsed;
			}
			else
			{
				itemname_text.Visibility = Visibility.Visible;
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


		// purchase price
		private void purchase_price_text_MouseDown(object sender, MouseButtonEventArgs e)
		{
			purchase_price_txt.Focus();
		}

		private void purchase_price_txt_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(purchase_price_txt.Text) && purchase_price_txt.Text.Length > 0)
			{
				purchase_price_text.Visibility = Visibility.Collapsed;
			}
			else
			{
				purchase_price_text.Visibility = Visibility.Visible;
			}
		}


		// selling price
		private void selling_price_text_MouseDown(object sender, MouseButtonEventArgs e)
		{
			selling_price_txt.Focus();
		}

		private void selling_price_txt_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!string.IsNullOrEmpty(selling_price_txt.Text) && selling_price_txt.Text.Length > 0)
			{
				selling_price_text.Visibility = Visibility.Collapsed;
			}
			else
			{
				selling_price_text.Visibility = Visibility.Visible;
			}
		}

        private void inventory_enter_data_click(object sender, RoutedEventArgs e)
        {
			database.add_inventory(
				
				)
        }

        private void inventory_clear_fields_click(object sender, RoutedEventArgs e)
        {

        }

        private void inventory_exit_click(object sender, RoutedEventArgs e)
        {

        }

        private void inventory_add_to_database_click(object sender, RoutedEventArgs e)
        {

        }
    }

   
}
