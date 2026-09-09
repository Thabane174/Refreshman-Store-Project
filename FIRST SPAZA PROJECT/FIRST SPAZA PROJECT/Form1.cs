using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIRST_SPAZA_PROJECT
{
    public partial class frmFastFood : Form
    {
        public frmFastFood()
        {
            InitializeComponent();
        }

     
        private void btnBurger_Click(object sender, EventArgs e)
        {
            string Item, Description;

            Item = "BURGER" ;
            Description = "A juicy beef patty grilled to perfection\nand served with fresh lettuce,\ntomatoes, cheese,\nand a soft sesame buns.";

            lblDescripptionOutput.Text = Description;
            lblCatOutput.Text = Item;

        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            string Item, Description;

            Item = "PIZZA";
            Description = "Freshly baked pizza topped \nwith melted cheese, tomato sauce,\nand delicious mixed toppings.";

            lblDescripptionOutput.Text = Description;
            lblCatOutput.Text = Item;
        }

        private void btnShwama_Click(object sender, EventArgs e)
        {
            string Item, Description;

            Item = "SHWAMA";
            Description = "Tender grilled meat wrapped\nin a soft flatbread with\nfresh vegetables and creamy sauce.";

            lblDescripptionOutput.Text = Description;
            lblCatOutput.Text = Item;
        }

        private void btnSteak_Click(object sender, EventArgs e)
        {
            string Item, Description;

            Item = "BEEF STEAK";
            Description = "Premium beef steak grilled\nover an open flame, seasoned with herbs\nand spices for a rich flavor.";

            lblDescripptionOutput.Text = Description;
            lblCatOutput.Text = Item;
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            string Item, Description;

            Item = "CHICKEN";
            Description = "Flame-grilled chicken marinated\nin special spices,\nserved hot and juicy.";

            lblDescripptionOutput.Text = Description;
            lblCatOutput.Text = Item;
        }

        private void btnInhloko_Click(object sender, EventArgs e)
        {
            string Item, Description;

            Item = "INHLOKO";
            Description = "Traditional South African cooked,\nprepared with local spices\nand served as a hearty meal.";
            lblDescripptionOutput.Text = Description;
            lblCatOutput.Text = Item;
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            double BasicCost,FinalCost=0,Discount = 0;
            int Qty;

            Qty = (int)nudQuantity.Value;

            if (lblCatOutput.Text == "BURGER")
            {
                BasicCost = 40.00;
                if (Qty >=5)
                {
                    Discount = BasicCost*Qty * 0.1;
                    FinalCost = (BasicCost * Qty) - Discount;
                }
                else
                {
                    FinalCost = BasicCost * Qty;
                }

                lblDiscountOutput.Text = Discount.ToString("C");
                lblTotalOutput.Text = FinalCost.ToString("C");
            }

            else if(lblCatOutput.Text == "PIZZA")
            {
                BasicCost = 98.00;
                if (Qty >=5)
                {
                    Discount = BasicCost*Qty * 0.1;
                    FinalCost = (BasicCost * Qty) - Discount;
                }
                else
                {
                    FinalCost = BasicCost * Qty;
                }

                lblDiscountOutput.Text = Discount.ToString("C");
                lblTotalOutput.Text = FinalCost.ToString("C");
            }

             else if (lblCatOutput.Text == "SHWAMA")
            {
                BasicCost = 26.99;
                if (Qty >=5)
                {
                    Discount = BasicCost* Qty * 0.1;
                    FinalCost = (BasicCost * Qty) - Discount;
                }
                else
                {
                    FinalCost = BasicCost * Qty;
                }

                lblDiscountOutput.Text = Discount.ToString("C");
                lblTotalOutput.Text = FinalCost.ToString("C");
            }

             else if(lblCatOutput.Text =="BEEF STEAK")
            {
                BasicCost = 119.99;
                if (Qty >=5)
                {
                    Discount = BasicCost * Qty * 0.1;
                    FinalCost = (BasicCost * Qty) - Discount;
                }
                else
                {
                    FinalCost = BasicCost * Qty;
                }

                lblDiscountOutput.Text = Discount.ToString("C");
                lblTotalOutput.Text = FinalCost.ToString("C");
            }

             else if (lblCatOutput.Text == "CHICKEN")
            {
                BasicCost = 109.99;
                if (Qty >=5)
                {
                    Discount = BasicCost *Qty* 0.1;
                    FinalCost = (BasicCost * Qty) - Discount;
                }
                else
                {
                    FinalCost = BasicCost * Qty;
                }

                lblDiscountOutput.Text = Discount.ToString("C");
                lblTotalOutput.Text = FinalCost.ToString("C");
            }

            else if(lblCatOutput.Text=="INHLOKO")
            {
                BasicCost = 49.99;
                if (Qty >=5)
                {
                    Discount = BasicCost* Qty * 0.1;
                    FinalCost = (BasicCost * Qty) - Discount;
                }
                else
                {
                    FinalCost = BasicCost * Qty;
                }
                lblDiscountOutput.Text = Discount.ToString("C");
                lblTotalOutput.Text = FinalCost.ToString("C");
            }

            Random rnd = new Random();
            string OrderNumber;
            
            if (Qty == 0)
            {
                OrderNumber = "";
            }
            else
            {
                OrderNumber = DateTime.Now.ToString("yyyy/MM/dd") + "\n" + "Number :" + rnd.Next(1000, 9999);
            }
            lblOrderNumber.Text = "ORD-" + OrderNumber;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDescripptionOutput.Text = "********";
            lblCatOutput.Text = "********";
            nudQuantity.Text = "0";
            lblDiscountOutput.Text = "********";
            lblTotalOutput.Text = "********";
            lblOrderNumber.Text = "********";
        }
    }
}               
