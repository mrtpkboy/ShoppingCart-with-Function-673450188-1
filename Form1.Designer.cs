namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            Total = new Label();
            tbTotal = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbCoffeePrice = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            chbCoffee = new CheckBox();
            chbGreenTea = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            labell = new Label();
            label11 = new Label();
            label111 = new Label();
            label1111 = new Label();
            label11111 = new Label();
            label5 = new Label();
            label10 = new Label();
            tbCash = new TextBox();
            tb1000 = new TextBox();
            tbChange = new TextBox();
            tb100 = new TextBox();
            tb500 = new TextBox();
            tb50 = new TextBox();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(449, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 238);
            button1.TabIndex = 0;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(575, 16);
            Total.Name = "Total";
            Total.Size = new Size(32, 15);
            Total.TabIndex = 1;
            Total.Text = "Total";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(619, 12);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 2;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(148, 90);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 3;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(148, 39);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(100, 23);
            tbCoffeePrice.TabIndex = 4;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(276, 39);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(100, 23);
            tbCoffeeQuantity.TabIndex = 5;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(276, 90);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 6;
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(31, 39);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(61, 19);
            chbCoffee.TabIndex = 7;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(31, 90);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(73, 19);
            chbGreenTea.TabIndex = 8;
            chbGreenTea.Text = "Greentea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(569, 59);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 9;
            label1.Text = "Cash";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(560, 89);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 10;
            label2.Text = "Change";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(569, 124);
            label.Name = "label";
            label.Size = new Size(31, 15);
            label.TabIndex = 11;
            label.Text = "1000";
            label.Click += tb1000_Click;
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Location = new Point(569, 162);
            labell.Name = "labell";
            labell.Size = new Size(25, 15);
            labell.TabIndex = 12;
            labell.Text = "500";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(569, 198);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 13;
            label11.Text = "100";
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Location = new Point(575, 234);
            label111.Name = "label111";
            label111.Size = new Size(19, 15);
            label111.TabIndex = 14;
            label111.Text = "50";
            label111.Click += label6_Click;
            // 
            // label1111
            // 
            label1111.AutoSize = true;
            label1111.Location = new Point(575, 274);
            label1111.Name = "label1111";
            label1111.Size = new Size(19, 15);
            label1111.TabIndex = 15;
            label1111.Text = "20";
            // 
            // label11111
            // 
            label11111.AutoSize = true;
            label11111.Location = new Point(575, 307);
            label11111.Name = "label11111";
            label11111.Size = new Size(19, 15);
            label11111.TabIndex = 16;
            label11111.Text = "10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(581, 350);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 17;
            label5.Text = "5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(581, 387);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 18;
            label10.Text = "1";
            // 
            // tbCash
            // 
            tbCash.Location = new Point(619, 51);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(100, 23);
            tbCash.TabIndex = 19;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(619, 121);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(100, 23);
            tb1000.TabIndex = 20;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(619, 89);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(100, 23);
            tbChange.TabIndex = 21;
            // 
            // tb100
            // 
            tb100.Location = new Point(619, 195);
            tb100.Name = "tb100";
            tb100.Size = new Size(100, 23);
            tb100.TabIndex = 22;
            // 
            // tb500
            // 
            tb500.Location = new Point(619, 159);
            tb500.Name = "tb500";
            tb500.Size = new Size(100, 23);
            tb500.TabIndex = 23;
            // 
            // tb50
            // 
            tb50.Location = new Point(619, 234);
            tb50.Name = "tb50";
            tb50.Size = new Size(100, 23);
            tb50.TabIndex = 24;
            // 
            // tb20
            // 
            tb20.Location = new Point(619, 271);
            tb20.Name = "tb20";
            tb20.Size = new Size(100, 23);
            tb20.TabIndex = 25;
            // 
            // tb10
            // 
            tb10.Location = new Point(619, 304);
            tb10.Name = "tb10";
            tb10.Size = new Size(100, 23);
            tb10.TabIndex = 26;
            // 
            // tb5
            // 
            tb5.Location = new Point(619, 342);
            tb5.Name = "tb5";
            tb5.Size = new Size(100, 23);
            tb5.TabIndex = 27;
            // 
            // tb1
            // 
            tb1.Location = new Point(619, 379);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 450);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb500);
            Controls.Add(tb100);
            Controls.Add(tbChange);
            Controls.Add(tb1000);
            Controls.Add(tbCash);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label11111);
            Controls.Add(label1111);
            Controls.Add(label111);
            Controls.Add(label11);
            Controls.Add(labell);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chbGreenTea);
            Controls.Add(chbCoffee);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbCoffeePrice);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(tbTotal);
            Controls.Add(Total);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Total;
        private TextBox tbTotal;
        private TextBox tbGreenTeaPrice;
        private TextBox tbCoffeePrice;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaQuantity;
        private CheckBox chbCoffee;
        private CheckBox chbGreenTea;
        private Label label1;
        private Label label2;
        private Label label;
        private Label labell;
        private Label label11;
        private Label label111;
        private Label label1111;
        private Label label11111;
        private Label label5;
        private Label label10;
        private TextBox tbCash;
        private TextBox tb1000;
        private TextBox tbChange;
        private TextBox tb100;
        private TextBox tb500;
        private TextBox tb50;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb5;
        private TextBox tb1;
    }
}
