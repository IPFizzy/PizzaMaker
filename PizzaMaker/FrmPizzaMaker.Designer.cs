namespace PizzaMaker
{
    partial class FrmPizzaMaker
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
            lblName = new Label();
            txtName = new TextBox();
            grpIngredients = new GroupBox();
            chbPineapple = new CheckBox();
            chbBacon = new CheckBox();
            chbSausage = new CheckBox();
            chbOlives = new CheckBox();
            chbPeppers = new CheckBox();
            chbMushrooms = new CheckBox();
            chbTomatoes = new CheckBox();
            chbPepperoni = new CheckBox();
            lblAddOns = new Label();
            lsbStrangeAddOns = new ListBox();
            grpCrust = new GroupBox();
            rdoGlutenFree = new RadioButton();
            rdoDeepDish = new RadioButton();
            rdoStuffedCrust = new RadioButton();
            rdoThinCrust = new RadioButton();
            grpExtraGoodies = new GroupBox();
            lblSauce = new Label();
            lblAmountOfCheese = new Label();
            lblCheese = new Label();
            lblAmountOfSauce = new Label();
            hsbCheese = new HScrollBar();
            hsbSauce = new HScrollBar();
            lblDeliveryTime = new Label();
            dtpDeliveryTime = new DateTimePicker();
            lblColor = new Label();
            picPizzaBoxColor = new PictureBox();
            lblPrice = new Label();
            lblPizzaPrice = new Label();
            btnResetForm = new Button();
            btnCreatePizza = new Button();
            grpIngredients.SuspendLayout();
            grpCrust.SuspendLayout();
            grpExtraGoodies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 18);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(67, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 26);
            txtName.TabIndex = 1;
            txtName.Leave += TxtNameLeaveEH;
            // 
            // grpIngredients
            // 
            grpIngredients.Controls.Add(chbPineapple);
            grpIngredients.Controls.Add(chbBacon);
            grpIngredients.Controls.Add(chbSausage);
            grpIngredients.Controls.Add(chbOlives);
            grpIngredients.Controls.Add(chbPeppers);
            grpIngredients.Controls.Add(chbMushrooms);
            grpIngredients.Controls.Add(chbTomatoes);
            grpIngredients.Controls.Add(chbPepperoni);
            grpIngredients.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpIngredients.Location = new Point(12, 38);
            grpIngredients.Name = "grpIngredients";
            grpIngredients.Size = new Size(236, 140);
            grpIngredients.TabIndex = 2;
            grpIngredients.TabStop = false;
            grpIngredients.Text = "Ingredients";
            // 
            // chbPineapple
            // 
            chbPineapple.AutoSize = true;
            chbPineapple.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPineapple.Location = new Point(132, 25);
            chbPineapple.Name = "chbPineapple";
            chbPineapple.Size = new Size(96, 22);
            chbPineapple.TabIndex = 10;
            chbPineapple.Text = "Pineapple";
            chbPineapple.UseVisualStyleBackColor = true;
            chbPineapple.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbBacon
            // 
            chbBacon.AutoSize = true;
            chbBacon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbBacon.Location = new Point(15, 53);
            chbBacon.Name = "chbBacon";
            chbBacon.Size = new Size(69, 22);
            chbBacon.TabIndex = 9;
            chbBacon.Text = "Bacon";
            chbBacon.UseVisualStyleBackColor = true;
            chbBacon.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbSausage
            // 
            chbSausage.AutoSize = true;
            chbSausage.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbSausage.Location = new Point(132, 53);
            chbSausage.Name = "chbSausage";
            chbSausage.Size = new Size(84, 22);
            chbSausage.TabIndex = 8;
            chbSausage.Text = "Sausage";
            chbSausage.UseVisualStyleBackColor = true;
            chbSausage.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbOlives
            // 
            chbOlives.AutoSize = true;
            chbOlives.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbOlives.Location = new Point(15, 81);
            chbOlives.Name = "chbOlives";
            chbOlives.Size = new Size(71, 22);
            chbOlives.TabIndex = 7;
            chbOlives.Text = "Olives";
            chbOlives.UseVisualStyleBackColor = true;
            chbOlives.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPeppers
            // 
            chbPeppers.AutoSize = true;
            chbPeppers.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPeppers.Location = new Point(132, 81);
            chbPeppers.Name = "chbPeppers";
            chbPeppers.Size = new Size(85, 22);
            chbPeppers.TabIndex = 6;
            chbPeppers.Text = "Peppers";
            chbPeppers.UseVisualStyleBackColor = true;
            chbPeppers.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbMushrooms
            // 
            chbMushrooms.AutoSize = true;
            chbMushrooms.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbMushrooms.Location = new Point(15, 109);
            chbMushrooms.Name = "chbMushrooms";
            chbMushrooms.Size = new Size(111, 22);
            chbMushrooms.TabIndex = 5;
            chbMushrooms.Text = "Mushrooms";
            chbMushrooms.UseVisualStyleBackColor = true;
            chbMushrooms.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbTomatoes
            // 
            chbTomatoes.AutoSize = true;
            chbTomatoes.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbTomatoes.Location = new Point(132, 109);
            chbTomatoes.Name = "chbTomatoes";
            chbTomatoes.Size = new Size(97, 22);
            chbTomatoes.TabIndex = 4;
            chbTomatoes.Text = "Tomatoes";
            chbTomatoes.UseVisualStyleBackColor = true;
            chbTomatoes.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // chbPepperoni
            // 
            chbPepperoni.AutoSize = true;
            chbPepperoni.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbPepperoni.Location = new Point(15, 25);
            chbPepperoni.Name = "chbPepperoni";
            chbPepperoni.Size = new Size(99, 22);
            chbPepperoni.TabIndex = 3;
            chbPepperoni.Text = "Pepperoni";
            chbPepperoni.UseVisualStyleBackColor = true;
            chbPepperoni.CheckedChanged += ChbIngredientCheckedChangedEH;
            // 
            // lblAddOns
            // 
            lblAddOns.AutoSize = true;
            lblAddOns.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddOns.Location = new Point(12, 181);
            lblAddOns.Name = "lblAddOns";
            lblAddOns.Size = new Size(146, 18);
            lblAddOns.TabIndex = 3;
            lblAddOns.Text = "Strange Add Ons";
            // 
            // lsbStrangeAddOns
            // 
            lsbStrangeAddOns.FormattingEnabled = true;
            lsbStrangeAddOns.Items.AddRange(new object[] { "Hotdogs", "Eggplant", "Artichoke Hearts", "Eggs", "Peanut Butter", "Prosciutto", "Honey", "Chili Thread", "Olive Oil", "Arugula", "Garlic", "Chicken", "Anchovies", "BBQ Sauce", "Green Onion", "Red Onion", "Carrots", "Peanuts" });
            lsbStrangeAddOns.Location = new Point(12, 202);
            lsbStrangeAddOns.Name = "lsbStrangeAddOns";
            lsbStrangeAddOns.SelectionMode = SelectionMode.MultiSimple;
            lsbStrangeAddOns.Size = new Size(155, 166);
            lsbStrangeAddOns.TabIndex = 4;
            lsbStrangeAddOns.SelectedIndexChanged += LsbStrangeAddOnsSelectedIndexChangedEH;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoGlutenFree);
            grpCrust.Controls.Add(rdoDeepDish);
            grpCrust.Controls.Add(rdoStuffedCrust);
            grpCrust.Controls.Add(rdoThinCrust);
            grpCrust.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCrust.Location = new Point(173, 181);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(139, 187);
            grpCrust.TabIndex = 5;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust";
            // 
            // rdoGlutenFree
            // 
            rdoGlutenFree.AutoSize = true;
            rdoGlutenFree.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoGlutenFree.Location = new Point(15, 109);
            rdoGlutenFree.Name = "rdoGlutenFree";
            rdoGlutenFree.Size = new Size(111, 22);
            rdoGlutenFree.TabIndex = 8;
            rdoGlutenFree.TabStop = true;
            rdoGlutenFree.Text = "Gluten Free";
            rdoGlutenFree.UseVisualStyleBackColor = true;
            rdoGlutenFree.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoDeepDish
            // 
            rdoDeepDish.AutoSize = true;
            rdoDeepDish.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoDeepDish.Location = new Point(15, 53);
            rdoDeepDish.Name = "rdoDeepDish";
            rdoDeepDish.Size = new Size(97, 22);
            rdoDeepDish.TabIndex = 7;
            rdoDeepDish.TabStop = true;
            rdoDeepDish.Text = "Deep Dish";
            rdoDeepDish.UseVisualStyleBackColor = true;
            rdoDeepDish.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoStuffedCrust
            // 
            rdoStuffedCrust.AutoSize = true;
            rdoStuffedCrust.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoStuffedCrust.Location = new Point(15, 81);
            rdoStuffedCrust.Name = "rdoStuffedCrust";
            rdoStuffedCrust.Size = new Size(120, 22);
            rdoStuffedCrust.TabIndex = 9;
            rdoStuffedCrust.TabStop = true;
            rdoStuffedCrust.Text = "Stuffed Crust";
            rdoStuffedCrust.UseVisualStyleBackColor = true;
            rdoStuffedCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoThinCrust
            // 
            rdoThinCrust.AutoSize = true;
            rdoThinCrust.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoThinCrust.Location = new Point(15, 25);
            rdoThinCrust.Name = "rdoThinCrust";
            rdoThinCrust.Size = new Size(102, 22);
            rdoThinCrust.TabIndex = 6;
            rdoThinCrust.TabStop = true;
            rdoThinCrust.Text = "Thin Crust";
            rdoThinCrust.UseVisualStyleBackColor = true;
            rdoThinCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // grpExtraGoodies
            // 
            grpExtraGoodies.Controls.Add(lblSauce);
            grpExtraGoodies.Controls.Add(lblAmountOfCheese);
            grpExtraGoodies.Controls.Add(lblCheese);
            grpExtraGoodies.Controls.Add(lblAmountOfSauce);
            grpExtraGoodies.Controls.Add(hsbCheese);
            grpExtraGoodies.Controls.Add(hsbSauce);
            grpExtraGoodies.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpExtraGoodies.Location = new Point(12, 374);
            grpExtraGoodies.Name = "grpExtraGoodies";
            grpExtraGoodies.Size = new Size(300, 154);
            grpExtraGoodies.TabIndex = 6;
            grpExtraGoodies.TabStop = false;
            grpExtraGoodies.Text = "Extra Goodies";
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSauce.Location = new Point(139, 22);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new Size(28, 18);
            lblSauce.TabIndex = 13;
            lblSauce.Text = "00";
            lblSauce.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmountOfCheese
            // 
            lblAmountOfCheese.AutoSize = true;
            lblAmountOfCheese.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountOfCheese.Location = new Point(6, 68);
            lblAmountOfCheese.Name = "lblAmountOfCheese";
            lblAmountOfCheese.Size = new Size(136, 18);
            lblAmountOfCheese.TabIndex = 12;
            lblAmountOfCheese.Text = "Amount of Cheese";
            // 
            // lblCheese
            // 
            lblCheese.AutoSize = true;
            lblCheese.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheese.Location = new Point(148, 68);
            lblCheese.Name = "lblCheese";
            lblCheese.Size = new Size(28, 18);
            lblCheese.TabIndex = 11;
            lblCheese.Text = "00";
            lblCheese.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmountOfSauce
            // 
            lblAmountOfSauce.AutoSize = true;
            lblAmountOfSauce.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountOfSauce.Location = new Point(6, 22);
            lblAmountOfSauce.Name = "lblAmountOfSauce";
            lblAmountOfSauce.Size = new Size(127, 18);
            lblAmountOfSauce.TabIndex = 10;
            lblAmountOfSauce.Text = "Amount of Sauce";
            // 
            // hsbCheese
            // 
            hsbCheese.Location = new Point(-3, 86);
            hsbCheese.Name = "hsbCheese";
            hsbCheese.Size = new Size(170, 20);
            hsbCheese.TabIndex = 8;
            hsbCheese.ValueChanged += HsbExtraGoodiesValueChangedEH;
            // 
            // hsbSauce
            // 
            hsbSauce.Location = new Point(-3, 40);
            hsbSauce.Name = "hsbSauce";
            hsbSauce.Size = new Size(170, 20);
            hsbSauce.TabIndex = 7;
            hsbSauce.ValueChanged += HsbExtraGoodiesValueChangedEH;
            // 
            // lblDeliveryTime
            // 
            lblDeliveryTime.AutoSize = true;
            lblDeliveryTime.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeliveryTime.Location = new Point(322, 9);
            lblDeliveryTime.Name = "lblDeliveryTime";
            lblDeliveryTime.Size = new Size(123, 18);
            lblDeliveryTime.TabIndex = 7;
            lblDeliveryTime.Text = "Delivery Time";
            // 
            // dtpDeliveryTime
            // 
            dtpDeliveryTime.CustomFormat = "MM/dd/yyyy hh:mm";
            dtpDeliveryTime.Format = DateTimePickerFormat.Custom;
            dtpDeliveryTime.Location = new Point(322, 30);
            dtpDeliveryTime.Name = "dtpDeliveryTime";
            dtpDeliveryTime.Size = new Size(218, 26);
            dtpDeliveryTime.TabIndex = 8;
            dtpDeliveryTime.ValueChanged += DtpDeliveryTimeValueChangedEH;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(322, 59);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(137, 18);
            lblColor.TabIndex = 9;
            lblColor.Text = "Pizza Box Color";
            // 
            // picPizzaBoxColor
            // 
            picPizzaBoxColor.BorderStyle = BorderStyle.FixedSingle;
            picPizzaBoxColor.Location = new Point(322, 80);
            picPizzaBoxColor.Name = "picPizzaBoxColor";
            picPizzaBoxColor.Size = new Size(211, 61);
            picPizzaBoxColor.TabIndex = 10;
            picPizzaBoxColor.TabStop = false;
            picPizzaBoxColor.Click += PicPizzaBoxColorClickEH;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(322, 144);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(106, 18);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Pizza Price:";
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.ForeColor = Color.Red;
            lblPizzaPrice.Location = new Point(434, 144);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(27, 18);
            lblPizzaPrice.TabIndex = 12;
            lblPizzaPrice.Text = "$0";
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(322, 165);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(102, 24);
            btnResetForm.TabIndex = 13;
            btnResetForm.Text = "Reset Form";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += BtnResetFormClickEH;
            // 
            // btnCreatePizza
            // 
            btnCreatePizza.Location = new Point(434, 165);
            btnCreatePizza.Name = "btnCreatePizza";
            btnCreatePizza.Size = new Size(106, 24);
            btnCreatePizza.TabIndex = 14;
            btnCreatePizza.Text = "Create Pizza";
            btnCreatePizza.UseVisualStyleBackColor = true;
            // 
            // FrmPizzaMaker
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 540);
            Controls.Add(btnCreatePizza);
            Controls.Add(btnResetForm);
            Controls.Add(lblPizzaPrice);
            Controls.Add(lblPrice);
            Controls.Add(picPizzaBoxColor);
            Controls.Add(lblColor);
            Controls.Add(dtpDeliveryTime);
            Controls.Add(lblDeliveryTime);
            Controls.Add(grpExtraGoodies);
            Controls.Add(grpCrust);
            Controls.Add(lsbStrangeAddOns);
            Controls.Add(lblAddOns);
            Controls.Add(grpIngredients);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmPizzaMaker";
            Text = "Pizza Maker";
            grpIngredients.ResumeLayout(false);
            grpIngredients.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpExtraGoodies.ResumeLayout(false);
            grpExtraGoodies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private GroupBox grpIngredients;
        private CheckBox chbPineapple;
        private CheckBox chbBacon;
        private CheckBox chbSausage;
        private CheckBox chbOlives;
        private CheckBox chbPeppers;
        private CheckBox chbMushrooms;
        private CheckBox chbTomatoes;
        private CheckBox chbPepperoni;
        private Label lblAddOns;
        private ListBox lsbStrangeAddOns;
        private GroupBox grpCrust;
        private RadioButton rdoGlutenFree;
        private RadioButton rdoDeepDish;
        private RadioButton rdoStuffedCrust;
        private RadioButton rdoThinCrust;
        private GroupBox grpExtraGoodies;
        private HScrollBar hsbCheese;
        private HScrollBar hsbSauce;
        private Label lblSauce;
        private Label lblAmountOfCheese;
        private Label lblCheese;
        private Label lblAmountOfSauce;
        private Label lblDeliveryTime;
        private DateTimePicker dtpDeliveryTime;
        private Label lblColor;
        private PictureBox picPizzaBoxColor;
        private Label lblPrice;
        private Label lblPizzaPrice;
        private Button btnResetForm;
        private Button btnCreatePizza;
    }
}
