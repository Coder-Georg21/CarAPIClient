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

namespace CarAPIClient.View
{
    /// <summary>
    /// Interaktionslogik für CarOverview.xaml
    /// </summary>
    public partial class CarOverview : Window
    {
        public CarOverview()
        {

            InitializeComponent();
        }
        public void OpenAddDialog(object sender, RoutedEventArgs e)
        {
            AddDialog addDialog = new AddDialog();
            addDialog.Show();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
