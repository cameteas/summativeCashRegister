namespace summativeCashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.burgers = new System.Windows.Forms.Label();
            this.fries = new System.Windows.Forms.Label();
            this.drinks = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.tendered = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.calcTotals = new System.Windows.Forms.Button();
            this.calcChange = new System.Windows.Forms.Button();
            this.printReciept = new System.Windows.Forms.Button();
            this.burgerNum = new System.Windows.Forms.TextBox();
            this.friesNum = new System.Windows.Forms.TextBox();
            this.drinkNum = new System.Windows.Forms.TextBox();
            this.moneyGiven = new System.Windows.Forms.TextBox();
            this.subTotalNum = new System.Windows.Forms.Label();
            this.taxNum = new System.Windows.Forms.Label();
            this.totalNum = new System.Windows.Forms.Label();
            this.changeNum = new System.Windows.Forms.Label();
            this.newWorldOrder = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgers
            // 
            this.burgers.AutoSize = true;
            this.burgers.Location = new System.Drawing.Point(12, 31);
            this.burgers.Name = "burgers";
            this.burgers.Size = new System.Drawing.Size(97, 13);
            this.burgers.TabIndex = 0;
            this.burgers.Text = "Number Of Burgers";
            // 
            // fries
            // 
            this.fries.AutoSize = true;
            this.fries.Location = new System.Drawing.Point(12, 66);
            this.fries.Name = "fries";
            this.fries.Size = new System.Drawing.Size(81, 13);
            this.fries.TabIndex = 1;
            this.fries.Text = "Number of Fries";
            // 
            // drinks
            // 
            this.drinks.AutoSize = true;
            this.drinks.Location = new System.Drawing.Point(12, 98);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(89, 13);
            this.drinks.TabIndex = 2;
            this.drinks.Text = "Number of Drinks";
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(17, 191);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(53, 13);
            this.subTotal.TabIndex = 3;
            this.subTotal.Text = "Sub Total";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Location = new System.Drawing.Point(17, 215);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(25, 13);
            this.tax.TabIndex = 4;
            this.tax.Text = "Tax";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(17, 239);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 5;
            this.total.Text = "Total";
            // 
            // tendered
            // 
            this.tendered.AutoSize = true;
            this.tendered.Location = new System.Drawing.Point(17, 297);
            this.tendered.Name = "tendered";
            this.tendered.Size = new System.Drawing.Size(53, 13);
            this.tendered.TabIndex = 6;
            this.tendered.Text = "Tendered";
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(23, 360);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(47, 13);
            this.change.TabIndex = 7;
            this.change.Text = "Change ";
            // 
            // calcTotals
            // 
            this.calcTotals.Location = new System.Drawing.Point(12, 133);
            this.calcTotals.Name = "calcTotals";
            this.calcTotals.Size = new System.Drawing.Size(139, 28);
            this.calcTotals.TabIndex = 8;
            this.calcTotals.Text = "Calculate Totals";
            this.calcTotals.UseVisualStyleBackColor = true;
            this.calcTotals.Click += new System.EventHandler(this.calcTotals_Click);
            // 
            // calcChange
            // 
            this.calcChange.Location = new System.Drawing.Point(12, 320);
            this.calcChange.Name = "calcChange";
            this.calcChange.Size = new System.Drawing.Size(139, 29);
            this.calcChange.TabIndex = 9;
            this.calcChange.Text = "Calculate Change";
            this.calcChange.UseVisualStyleBackColor = true;
            this.calcChange.Click += new System.EventHandler(this.calcChange_Click);
            // 
            // printReciept
            // 
            this.printReciept.Location = new System.Drawing.Point(12, 412);
            this.printReciept.Name = "printReciept";
            this.printReciept.Size = new System.Drawing.Size(270, 29);
            this.printReciept.TabIndex = 10;
            this.printReciept.Text = "Print Reciept";
            this.printReciept.UseVisualStyleBackColor = true;
            this.printReciept.Click += new System.EventHandler(this.printReciept_Click);
            // 
            // burgerNum
            // 
            this.burgerNum.Location = new System.Drawing.Point(116, 31);
            this.burgerNum.Name = "burgerNum";
            this.burgerNum.Size = new System.Drawing.Size(100, 20);
            this.burgerNum.TabIndex = 11;
            // 
            // friesNum
            // 
            this.friesNum.Location = new System.Drawing.Point(116, 66);
            this.friesNum.Name = "friesNum";
            this.friesNum.Size = new System.Drawing.Size(100, 20);
            this.friesNum.TabIndex = 12;
            // 
            // drinkNum
            // 
            this.drinkNum.Location = new System.Drawing.Point(116, 98);
            this.drinkNum.Name = "drinkNum";
            this.drinkNum.Size = new System.Drawing.Size(100, 20);
            this.drinkNum.TabIndex = 13;
            // 
            // moneyGiven
            // 
            this.moneyGiven.Location = new System.Drawing.Point(116, 294);
            this.moneyGiven.Name = "moneyGiven";
            this.moneyGiven.Size = new System.Drawing.Size(100, 20);
            this.moneyGiven.TabIndex = 14;
            // 
            // subTotalNum
            // 
            this.subTotalNum.AutoSize = true;
            this.subTotalNum.Location = new System.Drawing.Point(116, 191);
            this.subTotalNum.Name = "subTotalNum";
            this.subTotalNum.Size = new System.Drawing.Size(35, 13);
            this.subTotalNum.TabIndex = 15;
            this.subTotalNum.Text = "label1";
            // 
            // taxNum
            // 
            this.taxNum.AutoSize = true;
            this.taxNum.Location = new System.Drawing.Point(116, 215);
            this.taxNum.Name = "taxNum";
            this.taxNum.Size = new System.Drawing.Size(35, 13);
            this.taxNum.TabIndex = 16;
            this.taxNum.Text = "label2";
            // 
            // totalNum
            // 
            this.totalNum.AutoSize = true;
            this.totalNum.Location = new System.Drawing.Point(116, 239);
            this.totalNum.Name = "totalNum";
            this.totalNum.Size = new System.Drawing.Size(35, 13);
            this.totalNum.TabIndex = 17;
            this.totalNum.Text = "label3";
            // 
            // changeNum
            // 
            this.changeNum.AutoSize = true;
            this.changeNum.Location = new System.Drawing.Point(116, 360);
            this.changeNum.Name = "changeNum";
            this.changeNum.Size = new System.Drawing.Size(35, 13);
            this.changeNum.TabIndex = 18;
            this.changeNum.Text = "label4";
            // 
            // newWorldOrder
            // 
            this.newWorldOrder.Location = new System.Drawing.Point(288, 412);
            this.newWorldOrder.Name = "newWorldOrder";
            this.newWorldOrder.Size = new System.Drawing.Size(284, 29);
            this.newWorldOrder.TabIndex = 19;
            this.newWorldOrder.Text = "New Order";
            this.newWorldOrder.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(285, 38);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(44, 13);
            this.output.TabIndex = 20;
            this.output.Text = "Reciept";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.output);
            this.Controls.Add(this.newWorldOrder);
            this.Controls.Add(this.changeNum);
            this.Controls.Add(this.totalNum);
            this.Controls.Add(this.taxNum);
            this.Controls.Add(this.subTotalNum);
            this.Controls.Add(this.moneyGiven);
            this.Controls.Add(this.drinkNum);
            this.Controls.Add(this.friesNum);
            this.Controls.Add(this.burgerNum);
            this.Controls.Add(this.printReciept);
            this.Controls.Add(this.calcChange);
            this.Controls.Add(this.calcTotals);
            this.Controls.Add(this.change);
            this.Controls.Add(this.tendered);
            this.Controls.Add(this.total);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.fries);
            this.Controls.Add(this.burgers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgers;
        private System.Windows.Forms.Label fries;
        private System.Windows.Forms.Label drinks;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label tendered;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Button calcTotals;
        private System.Windows.Forms.Button calcChange;
        private System.Windows.Forms.Button printReciept;
        private System.Windows.Forms.TextBox burgerNum;
        private System.Windows.Forms.TextBox friesNum;
        private System.Windows.Forms.TextBox drinkNum;
        private System.Windows.Forms.TextBox moneyGiven;
        private System.Windows.Forms.Label subTotalNum;
        private System.Windows.Forms.Label taxNum;
        private System.Windows.Forms.Label totalNum;
        private System.Windows.Forms.Label changeNum;
        private System.Windows.Forms.Button newWorldOrder;
        private System.Windows.Forms.Label output;
    }
}

