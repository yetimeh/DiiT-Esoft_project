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


        }
    }
}
