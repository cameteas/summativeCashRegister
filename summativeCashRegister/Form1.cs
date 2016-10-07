using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace summativeCashRegister
{
    public partial class Form1 : Form
    {
        //declaring variables
        const double BURGERCOST = 2.49;
        const double FRIESCOST = 1.89;
        const double DRANKCOST = 0.99;
        const double HST = 0.13;
        int burger;
        int drank;
        int frie;
        int stageValue = 1;
        int orderNum = 0;
        double sub;
        double subTax;
        double tot;
        double bill;
        double balance;
        double ordBurgPrice;
        double ordFriePrice;
        double ordDrankPrice;
        Font receiptFont = new Font("Consolas", 11);
        SolidBrush receiptBrush = new SolidBrush(Color.Black);
        
        public Form1()
        {
            InitializeComponent();
        }

        //stage 1 calculating/printing totals
        private void calcTotals_Click(object sender, EventArgs e)
        {
            if (stageValue == 1)
            {
                calcTotals.BackColor = Color.WhiteSmoke;
                burgers.ForeColor = Color.LightGray;
                drinks.ForeColor = Color.LightGray;
                fries.ForeColor = Color.LightGray;
                burgerNum.BackColor = Color.WhiteSmoke;
                drinkNum.BackColor = Color.WhiteSmoke;
                friesNum.BackColor = Color.WhiteSmoke;
                burgerNum.ForeColor = Color.LightGray;
                friesNum.ForeColor = Color.LightGray;
                drinkNum.ForeColor = Color.LightGray;
                calcTotals.ForeColor = Color.LightGray;

                try
                {

                    burger = Convert.ToInt16(burgerNum.Text);
                    drank = Convert.ToInt16(drinkNum.Text);
                    frie = Convert.ToInt16(friesNum.Text);

                    ordBurgPrice = burger * BURGERCOST;
                    ordFriePrice = frie * FRIESCOST;
                    ordDrankPrice = drank * DRANKCOST;

                    sub = burger * BURGERCOST + frie * FRIESCOST + drank * DRANKCOST;
                    subTotalNum.Text = sub.ToString("$0.00");

                    subTax = sub * HST;
                    taxNum.Text = subTax.ToString("$0.00");

                    tot = subTax + sub;
                    totalNum.Text = tot.ToString("$0.00");
                    stageValue++;
                }
                catch
                {
                    notNum.Text = "Make Sure your menu items are \n Numbers";
                }
                Refresh();
                
            }
        }

        //stage 2 calculate change
        private void calcChange_Click(object sender, EventArgs e)
        {
            if(bill <= tot)
            {
                if (stageValue == 2)
                {
                    calcChange.BackColor = Color.WhiteSmoke;
                    calcChange.ForeColor = Color.LightGray;
                    subTotal.ForeColor = Color.LightGray;
                    subTotalNum.ForeColor = Color.LightGray;
                    tax.ForeColor = Color.LightGray;
                    taxNum.ForeColor = Color.LightGray;
                    total.ForeColor = Color.LightGray;
                    totalNum.ForeColor = Color.LightGray;
                    moneyGiven.BackColor = Color.WhiteSmoke;
                    moneyGiven.ForeColor = Color.LightGray;
                    tendered.ForeColor = Color.LightGray;

                    try
                    {
                        bill = Convert.ToDouble(moneyGiven.Text);
                        balance = bill - tot;
                        changeNum.Text = balance.ToString("$0.00");
                        stageValue++;
                    }
                    catch
                    {
                        changeNum.Text = "that's not a valid change amount";
                    }
                }
            }
            else
            {
                changeNum.Text = "that Simply is not enough money";
            }
        }
        //stage 3 print receipt
        private void printReciept_Click(object sender, EventArgs e)
        {
            if (stageValue == 3)
            {
                change.ForeColor = Color.LightGray;
                changeNum.ForeColor = Color.LightGray;
                printReciept.ForeColor = Color.LightGray;
                printReciept.BackColor = Color.WhiteSmoke;
                Graphics reciept = this.CreateGraphics();
                orderNum++;
                reciept.DrawString("    Mr.Burger's Burger Shack \n         of Beef Burgers" +
                    "\n\n         Order Number " + orderNum +
                    "\n       Date October 23 2001" +
                    "\n\nHamburgers   x" + burger + "   @2.49     =   " + ordBurgPrice.ToString("$0.00") +
                    "\nFries        x" + frie + "   @1.89     =   " + ordFriePrice.ToString("$0.00") +
                    "\nDranks       x" + drank + "   @0.99     =   " + ordDrankPrice.ToString("$0.00") +
                    "\n\nSubtotal                    =   " + sub.ToString("$0.00") +
                    "\nHST                         =   " + subTax.ToString("$0.00") +
                    "\nTotal                       =   " + tot.ToString("$0.00") +
                    "\n\nTenedered                   =   " + bill.ToString("$0.00") +
                    "\nReturned                    =   " + balance.ToString("$0.00"), receiptFont, receiptBrush, 250, 20);
                stageValue++;
            }
        }

        private void newWorldOrder_Click(object sender, EventArgs e)
        {
            stageValue = 1;
        }
    }
}
