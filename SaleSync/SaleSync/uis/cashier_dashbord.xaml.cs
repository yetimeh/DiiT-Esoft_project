using esoftprojecttest.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for admin_dashbord.xaml
    /// </summary>
    public partial class cashier_dashbord : Window
    {

		private Dictionary<string, dynamic> user;
		private DatabaseAPI database = new DatabaseAPI();
        private int total;
        public cashier_dashbord(Dictionary<string, dynamic> user)
        {
			this.user = user;
            InitializeComponent();
        }

		// item code
		private void itemcode_text_MouseDown(object sender, MouseButtonEventArgs e)
		{
			ICode_txt.Focus();
		}

        private void close_img(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
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

        private void cashier_my_profile_click(object sender, RoutedEventArgs e)
        {
			this.Hide();

			profile_page cashier_profile = new profile_page(user);
			cashier_profile.Show();
        }

        private void sell_click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Sold item(s)! Your total is {total}", "Happy shopping :)");

            // TODO: Add to history table

            //foreach (var item in cashier_data.Items)
            //{
            //    string item_code = "default_code";
            //    string item_name = "default_name";
            //    int quantity = 0;
            //    int selling_price = 0;
            //    int purchase_price = 0;

            //    var properties = item.GetType().GetProperties();
            //    foreach (var property in properties)
            //    {
            //        string propertyName = property.Name;
            //        string propertyValue = property.GetValue(item).ToString();


            //        switch (propertyName)
            //        {
            //            case "ItemCode":
            //                item_code = propertyValue;
            //                break;

            //            case "ItemName":
            //                item_name = propertyValue;
            //                break;

            //            case "Quantity":
            //                quantity = Convert.ToInt32(propertyValue);
            //                break;

                    
                     

            //            default: break;
            //        }
            //    }
            //}
        }

           

        private void enter_click(object sender, RoutedEventArgs e)
        {
            if (ICode_txt.Text == "" || quantity_txt.Text == "") { MessageBox.Show("Please make sure you enter all the fields!"); return; }

            dynamic[] stock = database.get_stock(itemCode: ICode_txt.Text);

            // stock[]:
            //    0: irem_code
            //    1: selling_price


			if (stock == null) { MessageBox.Show("No item with that item code found!", "Error :("); return; }

			cashier_data.Items.Add(new {
				ItemCode = ICode_txt.Text,
				Quantity = quantity_txt.Text,

                ItemName = stock[0],
				Price = stock[1].ToString(),
				Total = Convert.ToInt32(quantity_txt.Text) * stock[1]


			}) ;

            total = Convert.ToInt32(quantity_txt.Text) * stock[1];
        }


    }
}
