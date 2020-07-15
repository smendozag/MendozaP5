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

namespace MendozaP5
{
    /// <summary>
    /// Interaction logic for UpdateSprocketForm.xaml
    /// </summary>
    public partial class UpdateSprocketForm : Window
    {
        private SprocketOrder order = new SprocketOrder();
        public int selectedIndex = 0;
        public UpdateSprocketForm()
        {
            InitializeComponent();

        }

        public Sprocket Sprocket { get; set;  }


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            //Error here
            int itemID = int.Parse(txbUpdateItemID.Text);
            int numTeeth = int.Parse(txbNumOfTeeth.Text);
            int numItems = int.Parse(txbNumOfItems.Text);

            //Error
            try
            {

                if (cbxItemType.Text == "Steel")
                {
                    Sprocket = new SteelSprocket(itemID, numItems, numTeeth );
                    //order.Add(Sprocket);
                    order.items.Add(Sprocket);
                }
                else if (cbxItemType.Text == "Aluminum")
                {
                    Sprocket = new AluminumSprocket(itemID, numItems, numTeeth);
                    order.items.Add(Sprocket);


                }
                else if (cbxItemType.Text == "Plastic")
                {
                    Sprocket = new PlasticSprocket(itemID, numItems, numTeeth);
                    order.items.Add(Sprocket);

                }

                DialogResult = true;
                Close();
            }

            catch (Exception)
            {
                DialogResult = false;
                Close();
            }
        
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

       
    }
}
