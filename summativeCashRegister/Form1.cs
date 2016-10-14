using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace summativeCashRegister
{
    public partial class Form1 : Form
    {
        //declaring variables

        int burger;
        int drank;
        int frie;
        int stageValue = 1;
        int orderNum = 0;
        int drawHeight = 20;
        int drawWidth = 250;

        const double BURGERCOST = 2.49;
        const double FRIESCOST = 1.89;
        const double DRANKCOST = 0.99;
        const double HST = 0.13;

        double sub;
        double subTax;
        double tot;
        double bill;
        double balance;
        double ordBurgPrice;
        double ordFriePrice;
        double ordDrankPrice;

        Font receiptFont = new Font("Consolas", 11);
        SolidBrush receiptBrush = new SolidBrush(Color.DimGray);
        SolidBrush paperBrush = new SolidBrush(Color.White);
        
        //startup
        public Form1()
        {
            InitializeComponent();
            printReciept.BackColor = Color.WhiteSmoke;
            printReciept.ForeColor = Color.LightGray;

        }

        //stage 1 calculating/printing totals
        private void calcTotals_Click(object sender, EventArgs e)
        {
            if (stageValue == 1)
            {
                //setting component colours
                calcTotals.BackColor = Color.WhiteSmoke;
                calcTotals.ForeColor = Color.LightGray;
                burgers.ForeColor = Color.LightGray;
                drinks.ForeColor = Color.LightGray;
                fries.ForeColor = Color.LightGray;
                burgerNum.BackColor = Color.WhiteSmoke;
                drinkNum.BackColor = Color.WhiteSmoke;
                friesNum.BackColor = Color.WhiteSmoke;
                burgerNum.ForeColor = Color.LightGray;
                friesNum.ForeColor = Color.LightGray;
                drinkNum.ForeColor = Color.LightGray;
                printReciept.ForeColor = Color.LightGray;
                printReciept.BackColor = Color.WhiteSmoke;

                //button function
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
                    notNum.Text = "";
                }
                //button failiure function
                catch
                {
                    notNum.Text = "Make Sure your menu items are \n Numbers";
                    calcTotals.BackColor = Color.Gainsboro;
                    calcTotals.ForeColor = Color.Black;
                    burgers.ForeColor = Color.Black;
                    drinks.ForeColor = Color.Black;
                    fries.ForeColor = Color.Black;
                    burgerNum.BackColor = Color.White;
                    drinkNum.BackColor = Color.White;
                    friesNum.BackColor = Color.White;
                    burgerNum.ForeColor = Color.Black;
                    friesNum.ForeColor = Color.Black;
                    drinkNum.ForeColor = Color.Black;
                    printReciept.ForeColor = Color.Black;
                    printReciept.BackColor = Color.Gainsboro;
                }
                Refresh();
            }
        }

        //stage 2 calculate change
        private void calcChange_Click(object sender, EventArgs e)
        {
                if (stageValue == 2)
                {
                //changing component colours
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
                    printReciept.BackColor = Color.Gainsboro;
                    printReciept.ForeColor = Color.Black;

                //button fuction
                    try
                    {
                        bill = Convert.ToDouble(moneyGiven.Text);
                        balance = bill - tot;
                        changeNum.Text = balance.ToString("$0.00"); 
                    }

                //button failiure function
                    catch
                    {
                        changeNum.Text = "that's not a valid change amount";
                    }
                }
            //make sure money tendered > cost
            if (bill >= tot)
            {
                stageValue++;
            }
            else
            {
                changeNum.Text = "that Simply is not enough money";
                calcChange.BackColor = Color.Gainsboro;
                calcChange.ForeColor = Color.Black;
                subTotal.ForeColor = Color.Black;
                subTotalNum.ForeColor = Color.Black;
                tax.ForeColor = Color.Black;
                taxNum.ForeColor = Color.Black;
                total.ForeColor = Color.Black;
                totalNum.ForeColor = Color.Black;
                tendered.ForeColor = Color.Black;
                moneyGiven.BackColor = Color.White;
                moneyGiven.ForeColor = Color.Black;
                tendered.ForeColor = Color.White;
                printReciept.BackColor = Color.WhiteSmoke;
                printReciept.ForeColor = Color.LightGray;
            }
        }
        //stage 3 print receipt
        private void printReciept_Click(object sender, EventArgs e)
        {
            if (stageValue == 3)
            {
                //changing component colours
                change.ForeColor = Color.LightGray;
                changeNum.ForeColor = Color.LightGray;
                printReciept.ForeColor = Color.LightGray;
                printReciept.BackColor = Color.WhiteSmoke;
                printReciept.BackColor = Color.WhiteSmoke;
                printReciept.ForeColor = Color.LightGray;
                Graphics reciept = this.CreateGraphics();
                orderNum++;
                
                //declaring reciept string
                string[] words = new string[] {
                    //0
                    "    Mr.Burger's Burger Shack",
                    "         of Beef Burgers",
                    "         Order Number " ,
                    orderNum.ToString(),

                    //4
                    "       Date October 23 2001",
                    "Hamburgers x",
                    burger.ToString(),
                    "   @2.49   =   " ,
                    ordBurgPrice.ToString("$0.00"),

                    //9
                    "Fries      x",
                    frie.ToString(),
                    "   @1.89   =   " ,
                    ordFriePrice.ToString("$0.00"),
                    "Dranks     x",

                    //14
                    drank.ToString() ,
                    "   @0.99   =   " ,
                    ordDrankPrice.ToString("$0.00"),
                    "Subtotal                     =   " ,
                    sub.ToString("$0.00") ,

                    //19
                    "HST                          =   " ,
                    subTax.ToString("$0.00") ,
                    "Total                        =   " ,
                    tot.ToString("$0.00") ,
                    "Tenedered                    =   " ,

                    //24
                    bill.ToString("$0.00") ,
                    "Returned                     =   " ,
                    balance.ToString("$0.00")
                };

                //printing reciept
                reciept.FillRectangle(paperBrush, 230, 10, 350, 380 + 15);
                SoundPlayer moneySound = new SoundPlayer(Properties.Resources.money);
                moneySound.Play();
                for ( int i = 0; i < words.Length; i++)
                {
                    if (i == 6 || i == 10 || i == 14)
                    {
                        drawWidth = drawWidth + 125;
                    }
                    else if (i == 3){
                        drawWidth = drawWidth + 180;
                    }
                    else if (i == 18 || i == 20 || i == 22 || i == 24 || i == 26)
                    {
                        drawWidth = drawWidth + 270;
                    }
                    else if (i == 7 || i == 11 || i == 15)
                    {
                        drawWidth = drawWidth + 25;
                    }
                    else if (i == 8 || i == 12 || i == 16)
                    {
                        drawWidth = drawWidth + 120;
                    }
                    else
                    {
                        drawHeight = drawHeight + 20;
                        drawWidth = 250;
                    }

                    //double space printing
                    if (i == 2 || i == 5|| i == 17 || i == 21)
                    {
                        drawHeight = drawHeight + 20;
                    }

                    reciept.DrawString(words[i], receiptFont, receiptBrush, drawWidth, drawHeight);
                    Thread.Sleep(200);
                }
                drawHeight = 20;
                stageValue++;
            }
        }
        
        private void newWorldOrder_Click(object sender, EventArgs e)
        {
            //reseting all components
            stageValue = 1;
            calcTotals.BackColor = Color.Gainsboro;
            burgers.ForeColor = Color.Black;
            drinks.ForeColor = Color.Black;
            fries.ForeColor = Color.Black;
            burgerNum.BackColor = Color.White;
            drinkNum.BackColor = Color.White;
            friesNum.BackColor = Color.White;
            burgerNum.ForeColor = Color.Black;
            friesNum.ForeColor = Color.Black;
            drinkNum.ForeColor = Color.Black;
            calcTotals.ForeColor = Color.Black;

            calcChange.BackColor = Color.Gainsboro;
            calcChange.ForeColor = Color.Black;
            subTotal.ForeColor = Color.Black;
            subTotalNum.ForeColor = Color.Black;
            tax.ForeColor = Color.Black;
            taxNum.ForeColor = Color.Black;
            total.ForeColor = Color.Black;
            totalNum.ForeColor = Color.Black;
            moneyGiven.BackColor = Color.White;
            moneyGiven.ForeColor = Color.Black;
            tendered.ForeColor = Color.Black;

            change.ForeColor = Color.Black;
            changeNum.ForeColor = Color.Black;
            printReciept.ForeColor = Color.LightGray;
            printReciept.BackColor = Color.WhiteSmoke;
            drinkNum.Text = "0";
            burgerNum.Text = "0";
            friesNum.Text = "0";
            moneyGiven.Text = "0";
            subTotalNum.Text = "";
            taxNum.Text = "";
            totalNum.Text = "";
            changeNum.Text = "";
        }
    }
}
