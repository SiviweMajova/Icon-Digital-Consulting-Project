using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Siviwe
{
    public partial class frmSales : Form
    {
        public int nItems;  
        struct Item
        {
            public string name;  
            public double price; 
        }
        public double totalSales;
        public double totalDiscount;
        public const double DisCount = 0.2;

        public frmSales()
        {
            InitializeComponent(); //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nItems = Convert.ToInt32(Interaction.InputBox("Enter the number of items on current sale", "Items", "", 0, 0)); //number of items purchased in one transaction
            int count = 0;

            Item[] array = new Item[nItems];
            for (int i = 0; i < nItems; i++)
            {
                array[i].name = Convert.ToString(Interaction.InputBox("Enter item description for item " + Convert.ToString(i + 1), "Description", "", 0, 0)); //Item name or desciption
                array[i].price = Convert.ToDouble(Interaction.InputBox("Enter the price of item " + Convert.ToString(i + 1), "Price", "", 0, 0));  //the sales amount for each item for a purchase

                totalSales += array[i].price;   //Calculate total sales before discount
                txtShoppingData.Text += Convert.ToString(i + 1) + ". " + array[i].name + ": R" + Convert.ToString(array[i].price) + Environment.NewLine;

                double tempDisc = array[i].price * DisCount; //20% discount with every purchase made

                if (array[i].price > 20)      //Look if there are any items that cost more than R20
                {
                    if (count < 3)    //A discount is given on a maximum of 3 items per purchase
                    {
                        count += 1;
                        totalDiscount += discount(tempDisc);   
                    }
                }               
            }
            txtShoppingData.Text += Environment.NewLine + "Total Sales: R" + Convert.ToString(totalSales);
            txtShoppingData.Text += Environment.NewLine + "Discount: R" + Convert.ToString(totalDiscount);
            txtShoppingData.Text += Environment.NewLine + "Total Payable: R" + Convert.ToString(totalSales - totalDiscount);
        }

        private double discount(double discount)
        {
            /*ondition: 
            The discount on each item is set to a minimum of R5, and a maximum of R20 */
            double dis = 0;

            if(discount >= 20)
            {
                dis = 20;
            }
            if(discount <= 5)
            {
                dis = 5;
            }
            if(discount > 5 && discount < 20)
            {
                dis = discount;
            }

            return dis;
        }
    }
}
