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
	/// Interaction logic for inventory.xaml
	/// </summary>
	public partial class inventory : Window
	{

		private DatabaseAPI database = new DatabaseAPI();
		private Dictionary<string, dynamic> user;
		public inventory(Dictionary<string, dynamic> user)
		{
			this.user = user;
			InitializeComponent();
		}

        private void close_img(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
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

		private void clear_all_fields()
		{
			ICode_txt.Clear();
			IName_txt.Clear();
			quantity_txt.Clear();
			selling_price_txt.Clear();
			purchase_price_txt.Clear();
		}

		private void inventory_enter_data_click(object sender, RoutedEventArgs e)
		{

			if (ICode_txt.Text == "" || IName_txt.Text == "" || quantity_txt.Text == "" || selling_price_txt.Text == "" || selling_price_txt.Text == "")
			{
				MessageBox.Show("You didn't enter all the required fields!", "Error", MessageBoxButton.OK);
				return;
			}


			inventory_table.Items.Add(new { ItemCode = ICode_txt.Text,
				ItemName = IName_txt.Text,
				Quantity = quantity_txt.Text,
				SellingPrice = selling_price_txt.Text, PurchasePrice = purchase_price_txt.Text });

			clear_all_fields();

		}

		private void inventory_clear_fields_click(object sender, RoutedEventArgs e)
		{
			clear_all_fields();

		}

		private void inventory_exit_click(object sender, RoutedEventArgs e)
		{
			this.Hide();

			Dashbord_Screen admin_dashboard = new Dashbord_Screen(user);
			admin_dashboard.Show();

		}

		private void inventory_add_to_database_click(object sender, RoutedEventArgs e)
		{


			foreach (var item in inventory_table.Items)
			{
				string item_code = "default_code";
				string item_name = "default_name";
				int quantity = 0;
				int selling_price = 0;
				int purchase_price = 0;

				var properties = item.GetType().GetProperties();
				foreach (var property in properties)
				{
					string propertyName = property.Name;
					string propertyValue = property.GetValue(item).ToString();



					switch (propertyName)
					{
						case "ItemCode":
							item_code = propertyValue;
							break;

						case "ItemName":
							item_name = propertyValue;
							break;

						case "Quantity":
							quantity = Convert.ToInt32(propertyValue);
							break;

						case "SellingPrice":
							selling_price = Convert.ToInt32(propertyValue);
							break;

						case "PurchasePrice":
							purchase_price = Convert.ToInt32(propertyValue);
							break;

						default: break;
					}
				}

				bool result_value = database.add_inventory(
					item_code: item_code,
					item_name: item_name,
					quantity: quantity,
					purchase_price: purchase_price,
					selling_price: selling_price

					);

				if (result_value) {
					
					clear_all_fields();
					MessageBox.Show("Data added to database succesfully!"); 
				}
			}





		}

        private void inventory_table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

      
    }

   

