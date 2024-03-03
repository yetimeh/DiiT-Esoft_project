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
	/// Interaction logic for users_window.xaml
	/// </summary>
	public partial class users_window : Window
	{
		public users_window()
		{
			InitializeComponent();
		}

		private void close_img(object sender, MouseButtonEventArgs e)
		{
			Application.Current.Shutdown();
		}

	}
}
