using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace MendozaP5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SprocketOrder order = new SprocketOrder();

        public MainWindow()
        {
            InitializeComponent();
            ListBoxItems.ItemsSource = order.Items;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            UpdateSprocketForm sprocketWindow = new UpdateSprocketForm();
            sprocketWindow.ShowDialog();
            if(sprocketWindow.DialogResult == true)
            {
                order.Add(sprocketWindow.Sprocket);
                txbResults.Text = order.ToString();
                
                MessageBox.Show("Dialog Ok");


            }else
            {
                MessageBox.Show("Dialog Cancelled ");

            }

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxItems.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure?","Warning", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    order.Remove((Sprocket)ListBoxItems.SelectedItem);
                }

            }
            else
            {
                MessageBox.Show("No Item selected.");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            order.CustomerName = txbCustomerName.Text;
            if (ckbxLocalPickup.IsChecked == true)
            {
                order.Address = null;
            }
            else
            {

                order.Address = new Address();
                order.Address.Street = txbStreet.Text;
                order.Address.City = txbCity.Text;
                order.Address.State = txbState.Text;
                order.Address.ZipCode = txbZIP.Text;

            }
            txbResults.Text = order.ToString();


            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == true)
            {
                using (StreamWriter file = new StreamWriter(saveFile.OpenFile()))
                {
                    foreach (var sprocket in order.items)
                    {
                        file.WriteLine(order.ToString());
                    }
                }
            }
        }

        private void ckbxLocalPickup_Checked(object sender, RoutedEventArgs e)
        {
            txbCity.Visibility = Visibility.Hidden;
            txbStreet.Visibility = Visibility.Hidden;
            txbState.Visibility = Visibility.Hidden;
            txbZIP.Visibility = Visibility.Hidden;

            lblCity.Visibility = Visibility.Hidden;
            lblState.Visibility = Visibility.Hidden;
            lblStreet.Visibility = Visibility.Hidden;
            lblZIP.Visibility = Visibility.Hidden;

        }

      

        private void ckbxLocalPickup_Unchecked(object sender, RoutedEventArgs e)
        {
       
            txbCity.Visibility = Visibility.Visible;
            txbStreet.Visibility = Visibility.Visible;
            txbState.Visibility = Visibility.Visible;
            txbZIP.Visibility = Visibility.Visible;

            lblCity.Visibility = Visibility.Visible;
            lblState.Visibility = Visibility.Visible;
            lblStreet.Visibility = Visibility.Visible;
            lblZIP.Visibility = Visibility.Visible;

        }

    }
}
