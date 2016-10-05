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
            subTotalNum.Text = sub.ToStri
        }
    }
}
