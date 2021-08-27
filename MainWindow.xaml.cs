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

namespace DAS_DW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            City_Combobox();
        }

        public class City
        {
            public int CityID { get; set; }
            public string CityName { get; set; }
        }

        private void City_Combobox()
        {
            List<City> list = new List<City>();
            list.Add(new City { CityID = 1, CityName = "City1" });
            list.Add(new City { CityID = 2, CityName = "City2" });
            list.Add(new City { CityID = 3, CityName = "City3" });
            cbxCity.ItemsSource = list;
            cbxCity.SelectedIndex = 0;
        }

        private void CityCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            string cityID = "";
            string cityName = "";
            if (cbxCity.SelectedItem != null)
            {
                cityID = cbxCity.SelectedValue.ToString();
                cityName = ((City)cbxCity.SelectedItem).CityName.ToString();
            }

            lblCityID.Content = cityID;
            lblCityName.Content = cityName;
        }

    }

}
