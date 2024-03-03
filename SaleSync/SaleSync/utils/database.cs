using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace esoftprojecttest.utils
{
    internal class DatabaseAPI
    {
        private SqlConnection con;
        
        public DatabaseAPI()
        {

            
            con = new SqlConnection("Data Source=YETI-PC\\MSSQLSERVER01;Initial Catalog=saleSyncDB;Integrated Security=True;");
        }

        public Dictionary<string, dynamic>? login(string username, string password)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE CONVERT(VARCHAR, user__id) = '" + username + "' AND CONVERT(VARCHAR, password) = '" + password + "'", con);
            con.Open();

            cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == false) { con.Close(); return null; }


            var return_value = new Dictionary<string, dynamic>() {
                { "full_name", reader["full_name"].ToString()},
                {"admin", reader["admin"].ToString() == "yes" ? true : false },


            };

            

            return return_value;
            
            
        }

        public bool create_user(string username, string password, string fullname, string phoneNumber, string nic, string imagePath, string admin ) {


            SqlCommand cmd = new SqlCommand("INSERT INTO users (user__id, password, full_name, phone_number, nic, image_path, admin) VALUES('" + username +"', '" + password + "', '" + fullname +"', '"+ phoneNumber +"', '"+nic+"', '"+imagePath+"', '"+admin+"')", con);
            con.Open();

            try {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully registered user! You can now return to the SignIn page to login!", "Success!", MessageBoxButton.OK);
                
                return true;

            } catch (Exception ex)
            {
                MessageBox.Show($"Error while registering user {ex}");
            }

            finally { con.Close(); }



            return false;

        }

        public bool add_inventory(string item_code, string item_name, int quantity, int selling_price, int purchase_price)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO stocks (item_code, item_name, quantity, selling_price, purchase_price) VALUES ('"+item_code+"', '"+item_name+"', "+quantity+", "+selling_price+", "+purchase_price+")", con);
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occured when adding to inventory {ex}", "Error", MessageBoxButton.OK);
                return false;
            }
            finally { con.Close(); }

            return true;
        }

        public dynamic[] get_stock(string itemCode)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM stocks WHERE CONVERT(VARCHAR, item_code) = '"+itemCode+"'",con);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();


                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == false) { con.Close(); return null; }

                return
                [
                    reader["item_code"].ToString(),
                    Convert.ToInt32(reader["selling_price"]),
                ];

            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show($"An error occured when fetching data {ex}");

            } 
            finally { con.Close();  }

        }

        
    }
}
