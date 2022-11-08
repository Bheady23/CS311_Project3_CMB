namespace CS311_Project3_CMB
{
    partial class frmPizza
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
            this.pictPizzaLogo1 = new System.Windows.Forms.PictureBox();
            this.lblResturant = new System.Windows.Forms.Label();
            this.pictPizzaLogo2 = new System.Windows.Forms.PictureBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.grpChoices = new System.Windows.Forms.GroupBox();
            this.ckbMush = new System.Windows.Forms.CheckBox();
            this.ckbExtraC = new System.Windows.Forms.CheckBox();
            this.ckbJale = new System.Windows.Forms.CheckBox();
            this.ckbBanPep = new System.Windows.Forms.CheckBox();
            this.ckbGrnO = new System.Windows.Forms.CheckBox();
            this.ckbBlkO = new System.Windows.Forms.CheckBox();
            this.ckbGrnPep = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbSpicySaus = new System.Windows.Forms.CheckBox();
            this.ckbCanada = new System.Windows.Forms.CheckBox();
            this.ckbSaus = new System.Windows.Forms.CheckBox();
            this.ckbPep = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.rtfOrderSummary = new System.Windows.Forms.RichTextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.btnCalcu = new System.Windows.Forms.Button();
            this.lblSub = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizzaLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizzaLogo2)).BeginInit();
            this.grpCrust.SuspendLayout();
            this.grpChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictPizzaLogo1
            // 
            this.pictPizzaLogo1.Image = global::CS311_Project3_CMB.Properties.Resources.pizzaClip21;
            this.pictPizzaLogo1.Location = new System.Drawing.Point(12, 2);
            this.pictPizzaLogo1.Name = "pictPizzaLogo1";
            this.pictPizzaLogo1.Size = new System.Drawing.Size(185, 175);
            this.pictPizzaLogo1.TabIndex = 0;
            this.pictPizzaLogo1.TabStop = false;
            // 
            // lblResturant
            // 
            this.lblResturant.AutoSize = true;
            this.lblResturant.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResturant.Location = new System.Drawing.Point(232, 31);
            this.lblResturant.Name = "lblResturant";
            this.lblResturant.Size = new System.Drawing.Size(1003, 128);
            this.lblResturant.TabIndex = 1;
            this.lblResturant.Text = "Momma Mia Pizzeria";
            // 
            // pictPizzaLogo2
            // 
            this.pictPizzaLogo2.Image = global::CS311_Project3_CMB.Properties.Resources.pizzaClip21;
            this.pictPizzaLogo2.Location = new System.Drawing.Point(1255, 2);
            this.pictPizzaLogo2.Name = "pictPizzaLogo2";
            this.pictPizzaLogo2.Size = new System.Drawing.Size(185, 175);
            this.pictPizzaLogo2.TabIndex = 2;
            this.pictPizzaLogo2.TabStop = false;
            // 
            // cboSize
            // 
            this.cboSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(34, 30);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(343, 33);
            this.cboSize.TabIndex = 3;
            this.cboSize.Text = "SIZE:";
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdoThick);
            this.grpCrust.Controls.Add(this.rdoRegular);
            this.grpCrust.Controls.Add(this.rdoThin);
            this.grpCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCrust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCrust.Location = new System.Drawing.Point(383, 30);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(358, 33);
            this.grpCrust.TabIndex = 4;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "CRUST:";
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(272, 2);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(83, 29);
            this.rdoThick.TabIndex = 2;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(163, 2);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(103, 29);
            this.rdoRegular.TabIndex = 1;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(82, 2);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(75, 29);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // grpChoices
            // 
            this.grpChoices.Controls.Add(this.ckbMush);
            this.grpChoices.Controls.Add(this.ckbExtraC);
            this.grpChoices.Controls.Add(this.ckbJale);
            this.grpChoices.Controls.Add(this.ckbBanPep);
            this.grpChoices.Controls.Add(this.ckbGrnO);
            this.grpChoices.Controls.Add(this.ckbBlkO);
            this.grpChoices.Controls.Add(this.ckbGrnPep);
            this.grpChoices.Controls.Add(this.ckbOnion);
            this.grpChoices.Controls.Add(this.ckbSpicySaus);
            this.grpChoices.Controls.Add(this.ckbCanada);
            this.grpChoices.Controls.Add(this.ckbSaus);
            this.grpChoices.Controls.Add(this.ckbPep);
            this.grpChoices.Controls.Add(this.lblToppings);
            this.grpChoices.Controls.Add(this.cboSize);
            this.grpChoices.Controls.Add(this.grpCrust);
            this.grpChoices.Location = new System.Drawing.Point(12, 183);
            this.grpChoices.Name = "grpChoices";
            this.grpChoices.Size = new System.Drawing.Size(748, 343);
            this.grpChoices.TabIndex = 5;
            this.grpChoices.TabStop = false;
            // 
            // ckbMush
            // 
            this.ckbMush.AutoSize = true;
            this.ckbMush.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbMush.Location = new System.Drawing.Point(444, 256);
            this.ckbMush.Name = "ckbMush";
            this.ckbMush.Size = new System.Drawing.Size(130, 29);
            this.ckbMush.TabIndex = 17;
            this.ckbMush.Text = "Mushroom";
            this.ckbMush.UseVisualStyleBackColor = true;
            // 
            // ckbExtraC
            // 
            this.ckbExtraC.AutoSize = true;
            this.ckbExtraC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbExtraC.Location = new System.Drawing.Point(444, 210);
            this.ckbExtraC.Name = "ckbExtraC";
            this.ckbExtraC.Size = new System.Drawing.Size(147, 29);
            this.ckbExtraC.TabIndex = 16;
            this.ckbExtraC.Text = "Extra Cheese";
            this.ckbExtraC.UseVisualStyleBackColor = true;
            // 
            // ckbJale
            // 
            this.ckbJale.AutoSize = true;
            this.ckbJale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbJale.Location = new System.Drawing.Point(444, 165);
            this.ckbJale.Name = "ckbJale";
            this.ckbJale.Size = new System.Drawing.Size(114, 29);
            this.ckbJale.TabIndex = 15;
            this.ckbJale.Text = "Jalepeno";
            this.ckbJale.UseVisualStyleBackColor = true;
            // 
            // ckbBanPep
            // 
            this.ckbBanPep.AutoSize = true;
            this.ckbBanPep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBanPep.Location = new System.Drawing.Point(444, 121);
            this.ckbBanPep.Name = "ckbBanPep";
            this.ckbBanPep.Size = new System.Drawing.Size(174, 29);
            this.ckbBanPep.TabIndex = 14;
            this.ckbBanPep.Text = "Banana Peppers";
            this.ckbBanPep.UseVisualStyleBackColor = true;
            // 
            // ckbGrnO
            // 
            this.ckbGrnO.AutoSize = true;
            this.ckbGrnO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGrnO.Location = new System.Drawing.Point(263, 256);
            this.ckbGrnO.Name = "ckbGrnO";
            this.ckbGrnO.Size = new System.Drawing.Size(146, 29);
            this.ckbGrnO.TabIndex = 13;
            this.ckbGrnO.Text = "Green Olives";
            this.ckbGrnO.UseVisualStyleBackColor = true;
            // 
            // ckbBlkO
            // 
            this.ckbBlkO.AutoSize = true;
            this.ckbBlkO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBlkO.Location = new System.Drawing.Point(263, 212);
            this.ckbBlkO.Name = "ckbBlkO";
            this.ckbBlkO.Size = new System.Drawing.Size(141, 29);
            this.ckbBlkO.TabIndex = 12;
            this.ckbBlkO.Text = "Black Olives";
            this.ckbBlkO.UseVisualStyleBackColor = true;
            // 
            // ckbGrnPep
            // 
            this.ckbGrnPep.AutoSize = true;
            this.ckbGrnPep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGrnPep.Location = new System.Drawing.Point(263, 165);
            this.ckbGrnPep.Name = "ckbGrnPep";
            this.ckbGrnPep.Size = new System.Drawing.Size(153, 29);
            this.ckbGrnPep.TabIndex = 11;
            this.ckbGrnPep.Text = "Green Pepper";
            this.ckbGrnPep.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(263, 121);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(90, 29);
            this.ckbOnion.TabIndex = 10;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicySaus
            // 
            this.ckbSpicySaus.AutoSize = true;
            this.ckbSpicySaus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSpicySaus.Location = new System.Drawing.Point(34, 256);
            this.ckbSpicySaus.Name = "ckbSpicySaus";
            this.ckbSpicySaus.Size = new System.Drawing.Size(217, 29);
            this.ckbSpicySaus.TabIndex = 9;
            this.ckbSpicySaus.Text = "Spicy Italian Sausage";
            this.ckbSpicySaus.UseVisualStyleBackColor = true;
            // 
            // ckbCanada
            // 
            this.ckbCanada.AutoSize = true;
            this.ckbCanada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbCanada.Location = new System.Drawing.Point(34, 210);
            this.ckbCanada.Name = "ckbCanada";
            this.ckbCanada.Size = new System.Drawing.Size(175, 29);
            this.ckbCanada.TabIndex = 8;
            this.ckbCanada.Text = "Canadian Bacon";
            this.ckbCanada.UseVisualStyleBackColor = true;
            // 
            // ckbSaus
            // 
            this.ckbSaus.AutoSize = true;
            this.ckbSaus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSaus.Location = new System.Drawing.Point(34, 165);
            this.ckbSaus.Name = "ckbSaus";
            this.ckbSaus.Size = new System.Drawing.Size(108, 29);
            this.ckbSaus.TabIndex = 7;
            this.ckbSaus.Text = "Sausage";
            this.ckbSaus.UseVisualStyleBackColor = true;
            // 
            // ckbPep
            // 
            this.ckbPep.AutoSize = true;
            this.ckbPep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbPep.Location = new System.Drawing.Point(34, 121);
            this.ckbPep.Name = "ckbPep";
            this.ckbPep.Size = new System.Drawing.Size(124, 29);
            this.ckbPep.TabIndex = 6;
            this.ckbPep.Text = "Pepperoni";
            this.ckbPep.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(34, 81);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(106, 25);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "TOPPINGS:";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.Location = new System.Drawing.Point(766, 187);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(157, 25);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "Order Summary: ";
            // 
            // rtfOrderSummary
            // 
            this.rtfOrderSummary.Location = new System.Drawing.Point(766, 215);
            this.rtfOrderSummary.Name = "rtfOrderSummary";
            this.rtfOrderSummary.Size = new System.Drawing.Size(663, 185);
            this.rtfOrderSummary.TabIndex = 7;
            this.rtfOrderSummary.Text = "";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(1279, 417);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(150, 31);
            this.txtSub.TabIndex = 8;
            // 
            // btnCalcu
            // 
            this.btnCalcu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcu.Location = new System.Drawing.Point(766, 414);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(392, 109);
            this.btnCalcu.TabIndex = 9;
            this.btnCalcu.Text = "Calculate";
            this.btnCalcu.UseVisualStyleBackColor = false;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSub.Location = new System.Drawing.Point(1173, 420);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(91, 25);
            this.lblSub.TabIndex = 10;
            this.lblSub.Text = "SubTotal:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(1281, 460);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(150, 31);
            this.txtTax.TabIndex = 11;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(1218, 463);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(46, 25);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "Tax:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1284, 505);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 31);
            this.txtTotal.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(1205, 504);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 25);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 538);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.rtfOrderSummary);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.grpChoices);
            this.Controls.Add(this.pictPizzaLogo2);
            this.Controls.Add(this.lblResturant);
            this.Controls.Add(this.pictPizzaLogo1);
            this.Name = "frmPizza";
            this.Text = "Momma Mia Pizzeria";
            ((System.ComponentModel.ISupportInitialize)(this.pictPizzaLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizzaLogo2)).EndInit();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpChoices.ResumeLayout(false);
            this.grpChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictPizzaLogo1;
        private Label lblResturant;
        private PictureBox pictPizzaLogo2;
        private ComboBox cboSize;
        private GroupBox grpCrust;
        private RadioButton rdoThin;
        private RadioButton rdoThick;
        private RadioButton rdoRegular;
        private GroupBox grpChoices;
        private CheckBox ckbMush;
        private CheckBox ckbExtraC;
        private CheckBox ckbJale;
        private CheckBox ckbBanPep;
        private CheckBox ckbGrnO;
        private CheckBox ckbBlkO;
        private CheckBox ckbGrnPep;
        private CheckBox ckbOnion;
        private CheckBox ckbSpicySaus;
        private CheckBox ckbCanada;
        private CheckBox ckbSaus;
        private CheckBox ckbPep;
        private Label lblToppings;
        private Label lblOrder;
        private RichTextBox rtfOrderSummary;
        private TextBox txtSub;
        private Button btnCalcu;
        private Label lblSub;
        private TextBox txtTax;
        private Label lblTax;
        private TextBox txtTotal;
        private Label lblTotal;
    }
}