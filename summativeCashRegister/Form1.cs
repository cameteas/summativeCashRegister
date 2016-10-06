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
        int stageValue = 0;
        int orderNum = 0;
        double sub;
        double subTax;
        double tot;
        double bill;
        double balance;
        double ordBurgPrice;
        double ordFriePrice;
        double ordDrankPrice;
        Font receiptFont = new Font("Consolas", 9);
        SolidBrush receiptBrush = new SolidBrush(Color.Red);

        public Form1()
        {
            InitializeComponent();
        }

        //stage 1 calculating/printing totals
        private void calcTotals_Click(object sender, EventArgs e)
        {
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
            }
            catch
            {
                notNum.Text = "Make Sure your menu items are \n Numbers";
            }
        }

        //calculate change
        private void calcChange_Click(object sender, EventArgs e)
        {
            try
            {
                bill = Convert.ToDouble(moneyGiven.Text);
                balance = bill - tot;
                changeNum.Text = balance.ToString("$0.00");
            }
            catch
            {
                changeNum.Text = "that's not a valid change amount";
            }
        }
        //stage 3 print receipt
        private void printReciept_Click(object sender, EventArgs e)
        {
            Graphics reciept = this.CreateGraphics();
            orderNum++;
            reciept.DrawString("Mr.Burger's Burger Shack of Beef Burgers \n Order Number " +
                orderNum +
                "\n date" +
                "\nHamburgers   x" + burger + "  =   " + ordBurgPrice.ToString("$0.00") +
                "\nFries        x" + frie + "  =   " + ordFriePrice.ToString("$0.00") +
                "\nDranks       x" + drank + "  =   " + ordDrankPrice.ToString("$0.00") +
                "\nSubtotal         =   " + sub.ToString("$0.00") +
                "\nHST              =   " + subTax.ToString("$0.00") +
                "\nTotal            =   " + tot.ToString("$0.00") +
                "\nTenedered        =   " + bill.ToString("$0.00") +
                "\nReturned         =   " + balance.ToString("$0.00"), receiptFont, receiptBrush, 250, 20) ;
        }
    }
}
