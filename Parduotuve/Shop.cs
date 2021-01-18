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
    public partial class ShopForm : Form
    {
        string[] ProdNames { get; }
        public static List<Product> AvailableProducts { get; set; }
        public static Basket Basket { get; set; }

        public ShopForm()
        {
            InitializeComponent();
            ProdNames = new string[] { "Basketball",
                                       "Football",
                                       "Voleyball",
                                       "Tennis ball",
                                       "Tennis racket",
                                       "Football shoes",
                                       "Basketball shoes",
                                       "Boxing gloves",
                                       "Hockey stick",
                                       "Hockey puck" };
            Basket = new Basket();
            AvailableProducts = Product.GetProducts(ProdNames);
            foreach (Product prod in AvailableProducts)
            {
                ProductsPanel.Controls.Add(new ShopGBControl(prod));
            }
        }

        public static double ChangePriceWeightLbls(Object obj, List<Product> basket)
        {
            //Changes the Weight Category and Basket price labels upon adding the item to basket
            //Or plusing/minusing the item in the basket
            double basketPrice = 0;
            double weight = 0;
            string weightCat;
            foreach(Product prod in basket)
            {
                basketPrice += prod.Price * prod.Quantity;
                weight += prod.Weight * prod.Quantity;
            }

            if(weight < 2)
            {
                weightCat = "S";
            }
            else if (weight < 5)
            {
                weightCat = "M";
            }
            else
            {
                weightCat = "L";
            }

            //Receives either ShopGBControl or BasketGBControl as a sender object
            Control objSender = (Control)obj;
            FlowLayoutPanel flpSender = (FlowLayoutPanel)objSender.Parent;
            ShopForm endParent = (ShopForm)flpSender.Parent;

            endParent.TrueBasketPriceLbl.Text = basketPrice.ToString();
            endParent.TrueWeightCatLbl.Text = weightCat;

            return basketPrice;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //Creates a DeliveryAndPurchase class and pens the Delivery and purchase Form upon click
            //Or shows an error mesage if the basket is empty (nothing to purchase)
            if (Basket.BasketList.Count > 0)
            {
                DeliveryAndPurchase buyNow = new DeliveryAndPurchase(Basket.BasketList, double.Parse(this.TrueBasketPriceLbl.Text), this.TrueWeightCatLbl.Text);
                buyNow.Show();
                return;
            }
            MessageBox.Show("Please put at least one item in the basket!");
        }
    }
}
