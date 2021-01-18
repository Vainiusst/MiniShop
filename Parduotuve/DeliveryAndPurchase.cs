using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parduotuve
{
    public partial class DeliveryAndPurchase : Form
    {
        List<Product> BasketList;
        double BasketPrice { get; set; }
        string WeightCat { get; set; }
        
        public DeliveryAndPurchase(List<Product> basketList, double basketPrice, string weightCat)
        {
            this.BasketList = basketList;
            this.BasketPrice = basketPrice;
            this.WeightCat = weightCat;

            InitializeComponent();

            TrueBasketPriceLbl.Text = this.BasketPrice.ToString() + " €";
            TrueWeightCatLbl.Text = this.WeightCat;
            TrueTotalLbl.Text = (this.BasketPrice + this.CalculateShipping(this.WeightCat)).ToString() + " €";
        }

        private double CalculateShipping(string weightCat)
        {
            //Calculating the shipping price
            double shippingPrice = 0;

            switch (weightCat)
            {
                case "S":
                    shippingPrice += 1.99;
                    break;
                case "M":
                    shippingPrice += 3.99;
                    break;
                case "L":
                    shippingPrice += 5.99;
                    break;
            }

            if (this.PostDeliveryRB.Checked)
            {
                shippingPrice += 2.99;
            }
            else if (this.SSTDeliveryRB.Checked)
            {
                shippingPrice += 1.99;
            }
            else if (this.CourierDeliveryRB.Checked)
            {
                shippingPrice += 5.99;
            }
            else if (this.InternatDeliveryRB.Checked)
            {
                shippingPrice += 10.99;
            }

            return shippingPrice;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Enables the button once some text has been entered
            //Could benefit from using some sort of method checking if the address is legitimate
            //But for now this is beyond this project's scope
            CompleteOrderBtn.Enabled = true;
            RB_Click(sender, e);
        }

        private void RB_Click(object sender, EventArgs e)
        {
            //Re-renders the delivery price and total price upon click of the radio-button or text field input
            double deliveryPrice = CalculateShipping(this.WeightCat);
            TrueDeliveryLbl.Text = deliveryPrice.ToString() + " €";
            TrueTotalLbl.Text = (this.BasketPrice + deliveryPrice).ToString() + " €";
        }

        private void CompleteOrderBtn_Click(object sender, EventArgs e)
        {
            //Pretend method for ending the shopping session
            if (AddressTB.Text.Length > 0)
            {
                this.Close();
                MessageBox.Show("Thank You! Your order has been received and will be processed soon");
                return;
            }
            MessageBox.Show("Please enter Your address!");
            DeliveryAddressLbl.ForeColor = Color.Red;
        }
    }
}
