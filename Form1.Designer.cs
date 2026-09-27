namespace Pizza_Project_Solution_
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSamll = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetFrom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSamll);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gbSize.Location = new System.Drawing.Point(12, 83);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 146);
            this.gbSize.TabIndex = 2;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(6, 106);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(60, 21);
            this.rbLarge.TabIndex = 4;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(6, 68);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(73, 21);
            this.rbMedium.TabIndex = 3;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSamll
            // 
            this.rbSamll.AutoSize = true;
            this.rbSamll.Location = new System.Drawing.Point(6, 29);
            this.rbSamll.Name = "rbSamll";
            this.rbSamll.Size = new System.Drawing.Size(57, 21);
            this.rbSamll.TabIndex = 2;
            this.rbSamll.TabStop = true;
            this.rbSamll.Tag = "20";
            this.rbSamll.Text = "Samll";
            this.rbSamll.UseVisualStyleBackColor = true;
            this.rbSamll.CheckedChanged += new System.EventHandler(this.rbSamll_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Location = new System.Drawing.Point(12, 254);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 100);
            this.gbCrustType.TabIndex = 5;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(6, 62);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(78, 17);
            this.rbThickCrust.TabIndex = 6;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(6, 29);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(74, 17);
            this.rbThinCrust.TabIndex = 5;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkTomatos);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Location = new System.Drawing.Point(250, 83);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(236, 133);
            this.gbToppings.TabIndex = 12;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(128, 89);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPeppers.TabIndex = 17;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Location = new System.Drawing.Point(11, 89);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(73, 17);
            this.chkTomatos.TabIndex = 16;
            this.chkTomatos.Tag = "5";
            this.chkTomatos.Text = "Tomatoes";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(128, 57);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 15;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(128, 27);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 14;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(11, 57);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 13;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(11, 27);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(85, 17);
            this.chkExtraChees.TabIndex = 12;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(232, 254);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(200, 100);
            this.gbWhereToEat.TabIndex = 15;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(92, 41);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(67, 17);
            this.rbTakeOut.TabIndex = 16;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(15, 41);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(52, 17);
            this.rbEatIn.TabIndex = 15;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(563, 116);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(62, 21);
            this.lblSize.TabIndex = 16;
            // 
            // lblCrustType
            // 
            this.lblCrustType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(597, 203);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(74, 17);
            this.lblCrustType.TabIndex = 17;
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(586, 242);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(78, 29);
            this.lblWhereToEat.TabIndex = 18;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(584, 296);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(100, 40);
            this.lblTotalPrice.TabIndex = 19;
            // 
            // lblToppings
            // 
            this.lblToppings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(538, 155);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(173, 35);
            this.lblToppings.TabIndex = 20;
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(247, 376);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(75, 23);
            this.btnOrderPizza.TabIndex = 21;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetFrom
            // 
            this.btnResetFrom.Location = new System.Drawing.Point(358, 376);
            this.btnResetFrom.Name = "btnResetFrom";
            this.btnResetFrom.Size = new System.Drawing.Size(75, 23);
            this.btnResetFrom.TabIndex = 22;
            this.btnResetFrom.Text = "Reset Form";
            this.btnResetFrom.UseVisualStyleBackColor = true;
            this.btnResetFrom.Click += new System.EventHandler(this.ResetFrom_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(527, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Order Summary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(527, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Where to Eat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Crust Type :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(524, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Toppings :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Size :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(70, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 47);
            this.button1.TabIndex = 29;
            this.button1.Text = "MAKE YOUR PIZZA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetFrom);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblWhereToEat);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblToppings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSamll;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbToppings;
        public System.Windows.Forms.CheckBox chkGreenPeppers;
        public System.Windows.Forms.CheckBox chkTomatos;
        public System.Windows.Forms.CheckBox chkOlives;
        public System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

