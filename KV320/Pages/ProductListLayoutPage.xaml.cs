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

namespace KV320.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductListLayoutPage.xaml
    /// </summary>
    public partial class ProductListLayoutPage : Page
    {
        public ProductListLayoutPage()
        {
            InitializeComponent();
            List<int> showlist = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                showlist.Add(i);
            }

            productLV.ItemsSource = showlist;
        }
    }
}
