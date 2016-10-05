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
        double sub;
        double subTax;
        double tot;
        double bill;
        double balance;
        int orderNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcTotals_Click(object sender, EventArgs e)
        {
            burger = Convert.ToInt16(burgerNum.Text);
            drank = Convert.ToInt16(drinkNum.Text);
            frie = Convert.ToInt16(friesNum.Text);

            sub = burger * BURGERCOST + frie * FRIESCOST + drank * DRANKCOST;
            subTotalNum.Text = sub.ToString("$0.00");

            subTax = sub * HST;
            taxNum.Text = subTax.ToString("$0.00");

            tot = subTax + sub;
            totalNum.Text = tot.ToString("$0.00");
        }

        private void calcChange_Click(object sender, EventArgs e)
        {
            bill = Convert.ToDouble(moneyGiven.Text);
            balance = bill - tot;
            changeNum.Text = balance.ToString("$0.00");
            
        }

        private void printReciept_Click(object sender, EventArgs e)
        {
            orderNum++;
            output.Text = "Mr.Burger's Burger Shack of Beef Burgers \n Order Number " + orderNum +
        }
    }
}
