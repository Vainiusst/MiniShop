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
    public partial class ShopGBControl : UserControl
    {
        Product paramProd;
        public ShopGBControl(Product prod)
        {
            InitializeComponent();

            paramProd = prod;
            this.Name = paramProd.Name;
            gb.Text = paramProd.Name;

            TruePriceLbl.Text = paramProd.Price.ToString() + " €";
            TrueQtyLbl.Text = paramProd.Quantity.ToString();

            AddToCart.Click += AddToBasket;
        }

        public static void AddToBasket(Object obj, EventArgs e)
        {
            //Adds a product to the basket
            Button addBtn = (Button)obj;
            GroupBox groupBox = (GroupBox)addBtn.Parent;
            ShopGBControl endParent = (ShopGBControl)groupBox.Parent;
            int prodQty = endParent.paramProd.Quantity;
            string boxName = groupBox.Text;

            //Loops through available products and checks if the name of ShopGBControl (the sender)
            //matches with the neame of the product, the quantity is more than 0 and the product
            //is not yet in the Basket and then adds it to the temporary basket.
            //Displays the appropriate error messages if a certain criterion is not met.
            foreach (Product prod in ShopForm.AvailableProducts)
            {
                if (prod.Name == boxName && prod.Quantity > 0 && !Basket.BasketList.Contains(prod))
                {
                    prodQty--;
                    endParent.TrueQtyLbl.Text = prodQty.ToString();
                    Basket.TempBasketList.Add(prod);
                    Basket.RenderBasket(groupBox);
                    ShopForm.ChangePriceWeightLbls(endParent, Basket.BasketList);
                    return;
                }
                else if (prod.Name == boxName && prod.Quantity == 0)
                {
                    MessageBox.Show($"Sorry, the {prod.Name.ToLower()} is out of stock.");
                    return;
                }
                else if (prod.Name == boxName && Basket.BasketList.Contains(prod))
                {
                    MessageBox.Show("The product is already in the basket!");
                    return;
                }
            }
            MessageBox.Show("An error has occured.");
        }

        public static void QtyChange(Object obj, Product prod)
        {
            //Changes the quantity shown in the ShopGBControl (Available products section)
            //Reveives BasketGBControl as sender
            BasketGBControl bgbcSender = (BasketGBControl)obj;
            FlowLayoutPanel flpSender = (FlowLayoutPanel)bgbcSender.Parent;
            Form endParent = (Form)flpSender.Parent;
            var flpList = endParent.Controls.OfType<FlowLayoutPanel>();
            
            //Loops through the FlowLayoutPanels in the ShoForm
            //Selects the necessary, then loops through the ShopGBControls in it
            //Upon finding the required Control, changes its Quantity label
            foreach(FlowLayoutPanel flp in flpList)
            {
                if (flp.Name == "ProductsPanel")
                {
                    var sgbcList = flp.Controls.OfType<ShopGBControl>();
                    foreach (ShopGBControl sgbc in sgbcList)
                    {
                        if (sgbc.Name == prod.Name)
                        {
                            sgbc.TrueQtyLbl.Text = prod.Quantity.ToString();
                        }
                    }
                }
            }
        }
    }
}
