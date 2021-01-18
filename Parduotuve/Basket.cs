using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parduotuve
{
    public class Basket
    {
        public static List<Product> BasketList { get; set; }

        //Temporary basket list is necessary in orider to add items to basket one by one 
        //And add only one control (Basket Group Box COntrol or BGBC) instead of re-rendering the entire basket
        public static List<Product> TempBasketList { get; set; }

        public Basket()
        {
            TempBasketList = new List<Product>();
            BasketList = new List<Product>();
        }

        public static void RenderBasket(GroupBox gbSender)
        {
            //Finding the final parent (the main form (ShopForm))
            ShopGBControl sgbcSender = (ShopGBControl)gbSender.Parent;
            FlowLayoutPanel flpSender = (FlowLayoutPanel)sgbcSender.Parent;
            Form baseForm = (Form)flpSender.Parent;

            //Generating an IEnumerable of required type
            var flpList = baseForm.Controls.OfType<FlowLayoutPanel>();

            //Looping through the flpList, looking for the needed FlowLayoutPanel
            //Checking whether the item is already in there and adding it if needed
            //Or displaying an error message
            foreach (var flp in flpList)
            {
                if (flp.Name == "BasketPanel")
                {
                    for (int i = 0; i < TempBasketList.Count; i++)
                    {
                        Product prod = TempBasketList[i];
                        if (!BasketList.Contains(prod))
                        {
                            prod.Quantity--;
                            Product basketProd = new Product(prod);
                            BasketList.Add(basketProd);
                            flp.Controls.Add(new BasketGBControl(basketProd));
                            TempBasketList.Clear();
                        }
                        else
                        {
                            TempBasketList.Clear();
                            MessageBox.Show("Product is in the basket already");
                        }
                    }
                }
            }
        }
    }
}
