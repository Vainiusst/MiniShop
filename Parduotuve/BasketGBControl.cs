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
    public partial class BasketGBControl : UserControl
    {
        Product paramProd;
        public BasketGBControl(Product prod)
        {
            InitializeComponent();

            paramProd = prod;
            this.Name = paramProd.Name;
            gb.Text = paramProd.Name;

            TruePriceLbl.Text = paramProd.Price.ToString() + " €";
            TrueQtyLbl.Text = paramProd.Quantity.ToString();

            PlusBtn.Click += PlusBtn_Click;
            MinusBtn.Click += MinusBtn_Click;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            //Finding the required parent controls
            Button btnSender = (Button)sender;
            GroupBox gbSender = (GroupBox)btnSender.Parent;
            BasketGBControl endParent = (BasketGBControl)gbSender.Parent;
            FlowLayoutPanel flpParent = (FlowLayoutPanel)endParent.Parent;
            Product prod = endParent.paramProd;

            //Checking the quantity of item in the basket and performing necessary actions accordingly
            //Decreasing quantity in basket, increasing quantity in available products, rerendering the labels
            //And, if necessary, removing the item from the basket
            if(prod.Quantity > 1)
            {
                prod.Quantity--;
                endParent.TrueQtyLbl.Text = prod.Quantity.ToString();
                foreach(Product productAv in ShopForm.AvailableProducts)
                {
                    if (productAv.Equals(prod))
                    {
                        productAv.Quantity++;
                        ShopGBControl.QtyChange(endParent, productAv);
                        ShopForm.ChangePriceWeightLbls(endParent, Basket.BasketList);
                        return;
                    }
                }
            }
            else if(prod.Quantity == 1)
            {
                foreach (Product productAv in ShopForm.AvailableProducts)
                {
                    if (productAv.Equals(prod))
                    {
                        productAv.Quantity++;
                        ShopGBControl.QtyChange(endParent, productAv);
                        ShopForm.ChangePriceWeightLbls(endParent, Basket.BasketList);
                        Basket.BasketList.Remove(prod);
                        flpParent.Controls.Remove(endParent);
                        return;
                    }
                }
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            //Finding the required parent controls
            Button btnSender = (Button)sender;
            GroupBox gbSender = (GroupBox)btnSender.Parent;
            BasketGBControl endParent = (BasketGBControl)gbSender.Parent;
            Product prod = endParent.paramProd;

            //Looping through the available products o find the right one
            //Decreasing its quantity, increasing the quantity in the basket
            //Or showing the error message if no more items can be added to the basket
            foreach (Product productAv in ShopForm.AvailableProducts)
            {
                if (productAv.Equals(prod))
                {
                    if (productAv.Quantity > 0)
                    {
                        prod.Quantity++;
                        endParent.TrueQtyLbl.Text = prod.Quantity.ToString();
                        productAv.Quantity--;
                        ShopGBControl.QtyChange(endParent, productAv);
                        ShopForm.ChangePriceWeightLbls(endParent, Basket.BasketList);
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Sorry, {prod.Name.ToLower()} is out of stock.");
                        return;
                    }
                }
            }
        }
    }
}
