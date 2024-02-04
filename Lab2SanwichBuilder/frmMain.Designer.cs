
namespace Lab2SanwichBuilder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.grbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.rdbDelivery = new System.Windows.Forms.RadioButton();
            this.rdbPIckUp = new System.Windows.Forms.RadioButton();
            this.lblDeliveryOption = new System.Windows.Forms.Label();
            this.cobSandwitchSize = new System.Windows.Forms.ComboBox();
            this.libBread = new System.Windows.Forms.ListBox();
            this.libSaues = new System.Windows.Forms.ListBox();
            this.grbMeat = new System.Windows.Forms.GroupBox();
            this.clbMeat = new System.Windows.Forms.CheckedListBox();
            this.grbCheese = new System.Windows.Forms.GroupBox();
            this.clbCheese = new System.Windows.Forms.CheckedListBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbTpggings = new System.Windows.Forms.GroupBox();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.grbExtra = new System.Windows.Forms.GroupBox();
            this.clbExtra = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.grbCustomerInfo.SuspendLayout();
            this.grbMeat.SuspendLayout();
            this.grbCheese.SuspendLayout();
            this.grbTpggings.SuspendLayout();
            this.grbExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 101);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 19);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 237);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 19);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(15, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(119, 24);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(150, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 24);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Text = "Last Name";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(15, 126);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(254, 24);
            this.txtStreet.TabIndex = 5;
            this.txtStreet.Text = "North Main St";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(15, 163);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(119, 24);
            this.txtCity.TabIndex = 6;
            this.txtCity.Text = "Philadelphia";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(150, 163);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(119, 24);
            this.txtState.TabIndex = 7;
            this.txtState.Text = "PA";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.Location = new System.Drawing.Point(15, 203);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(119, 24);
            this.txtZipCode.TabIndex = 8;
            this.txtZipCode.Text = "90132";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(15, 269);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(194, 24);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.Text = "2123424321";
            // 
            // grbCustomerInfo
            // 
            this.grbCustomerInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbCustomerInfo.Controls.Add(this.dtpOrderDate);
            this.grbCustomerInfo.Controls.Add(this.rdbDelivery);
            this.grbCustomerInfo.Controls.Add(this.rdbPIckUp);
            this.grbCustomerInfo.Controls.Add(this.lblDeliveryOption);
            this.grbCustomerInfo.Controls.Add(this.txtState);
            this.grbCustomerInfo.Controls.Add(this.txtPhoneNumber);
            this.grbCustomerInfo.Controls.Add(this.lblName);
            this.grbCustomerInfo.Controls.Add(this.txtZipCode);
            this.grbCustomerInfo.Controls.Add(this.lblAddress);
            this.grbCustomerInfo.Controls.Add(this.lblPhoneNumber);
            this.grbCustomerInfo.Controls.Add(this.txtCity);
            this.grbCustomerInfo.Controls.Add(this.txtFirstName);
            this.grbCustomerInfo.Controls.Add(this.txtStreet);
            this.grbCustomerInfo.Controls.Add(this.txtLastName);
            this.grbCustomerInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCustomerInfo.Location = new System.Drawing.Point(12, 50);
            this.grbCustomerInfo.Name = "grbCustomerInfo";
            this.grbCustomerInfo.Size = new System.Drawing.Size(313, 402);
            this.grbCustomerInfo.TabIndex = 10;
            this.grbCustomerInfo.TabStop = false;
            this.grbCustomerInfo.Text = "Customer Informanation";
            // 
            // rdbDelivery
            // 
            this.rdbDelivery.AutoSize = true;
            this.rdbDelivery.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDelivery.Location = new System.Drawing.Point(112, 327);
            this.rdbDelivery.Name = "rdbDelivery";
            this.rdbDelivery.Size = new System.Drawing.Size(76, 23);
            this.rdbDelivery.TabIndex = 12;
            this.rdbDelivery.TabStop = true;
            this.rdbDelivery.Text = "Delivery";
            this.rdbDelivery.UseVisualStyleBackColor = true;
            // 
            // rdbPIckUp
            // 
            this.rdbPIckUp.AutoSize = true;
            this.rdbPIckUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPIckUp.Location = new System.Drawing.Point(16, 327);
            this.rdbPIckUp.Name = "rdbPIckUp";
            this.rdbPIckUp.Size = new System.Drawing.Size(74, 23);
            this.rdbPIckUp.TabIndex = 11;
            this.rdbPIckUp.TabStop = true;
            this.rdbPIckUp.Text = "Pick Up";
            this.rdbPIckUp.UseVisualStyleBackColor = true;
            // 
            // lblDeliveryOption
            // 
            this.lblDeliveryOption.AutoSize = true;
            this.lblDeliveryOption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryOption.Location = new System.Drawing.Point(12, 305);
            this.lblDeliveryOption.Name = "lblDeliveryOption";
            this.lblDeliveryOption.Size = new System.Drawing.Size(185, 19);
            this.lblDeliveryOption.TabIndex = 10;
            this.lblDeliveryOption.Text = "Select Your Delivery Options";
            // 
            // cobSandwitchSize
            // 
            this.cobSandwitchSize.AllowDrop = true;
            this.cobSandwitchSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobSandwitchSize.FormattingEnabled = true;
            this.cobSandwitchSize.Location = new System.Drawing.Point(354, 50);
            this.cobSandwitchSize.Name = "cobSandwitchSize";
            this.cobSandwitchSize.Size = new System.Drawing.Size(182, 28);
            this.cobSandwitchSize.TabIndex = 12;
            this.cobSandwitchSize.Text = "Select The Size";
            // 
            // libBread
            // 
            this.libBread.AllowDrop = true;
            this.libBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libBread.FormattingEnabled = true;
            this.libBread.ItemHeight = 20;
            this.libBread.Location = new System.Drawing.Point(354, 112);
            this.libBread.Name = "libBread";
            this.libBread.Size = new System.Drawing.Size(182, 104);
            this.libBread.TabIndex = 13;
            // 
            // libSaues
            // 
            this.libSaues.AllowDrop = true;
            this.libSaues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libSaues.FormattingEnabled = true;
            this.libSaues.ItemHeight = 20;
            this.libSaues.Location = new System.Drawing.Point(354, 241);
            this.libSaues.Name = "libSaues";
            this.libSaues.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.libSaues.Size = new System.Drawing.Size(181, 104);
            this.libSaues.TabIndex = 14;
            // 
            // grbMeat
            // 
            this.grbMeat.Controls.Add(this.clbMeat);
            this.grbMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMeat.Location = new System.Drawing.Point(555, 52);
            this.grbMeat.Name = "grbMeat";
            this.grbMeat.Size = new System.Drawing.Size(209, 171);
            this.grbMeat.TabIndex = 29;
            this.grbMeat.TabStop = false;
            this.grbMeat.Text = "Select Your Meat";
            // 
            // clbMeat
            // 
            this.clbMeat.FormattingEnabled = true;
            this.clbMeat.Location = new System.Drawing.Point(18, 30);
            this.clbMeat.Name = "clbMeat";
            this.clbMeat.Size = new System.Drawing.Size(172, 123);
            this.clbMeat.TabIndex = 45;
            this.clbMeat.Tag = "";
            // 
            // grbCheese
            // 
            this.grbCheese.Controls.Add(this.clbCheese);
            this.grbCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCheese.Location = new System.Drawing.Point(791, 58);
            this.grbCheese.Name = "grbCheese";
            this.grbCheese.Size = new System.Drawing.Size(227, 165);
            this.grbCheese.TabIndex = 40;
            this.grbCheese.TabStop = false;
            this.grbCheese.Text = "Select Your Cheese";
            // 
            // clbCheese
            // 
            this.clbCheese.FormattingEnabled = true;
            this.clbCheese.Location = new System.Drawing.Point(20, 24);
            this.clbCheese.Name = "clbCheese";
            this.clbCheese.Size = new System.Drawing.Size(186, 123);
            this.clbCheese.TabIndex = 46;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(350, 348);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(66, 19);
            this.lblTip.TabIndex = 42;
            this.lblTip.Text = "Enter Tip:";
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTip.Location = new System.Drawing.Point(354, 376);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(119, 24);
            this.txtTip.TabIndex = 43;
            this.txtTip.Text = "0.00";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(354, 407);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 45);
            this.btnCalculate.TabIndex = 44;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbTpggings
            // 
            this.grbTpggings.Controls.Add(this.clbToppings);
            this.grbTpggings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTpggings.Location = new System.Drawing.Point(555, 238);
            this.grbTpggings.Name = "grbTpggings";
            this.grbTpggings.Size = new System.Drawing.Size(209, 161);
            this.grbTpggings.TabIndex = 45;
            this.grbTpggings.TabStop = false;
            this.grbTpggings.Text = "Select Your Toppings";
            // 
            // clbToppings
            // 
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Location = new System.Drawing.Point(18, 30);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(170, 106);
            this.clbToppings.TabIndex = 46;
            // 
            // grbExtra
            // 
            this.grbExtra.Controls.Add(this.clbExtra);
            this.grbExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbExtra.Location = new System.Drawing.Point(791, 238);
            this.grbExtra.Name = "grbExtra";
            this.grbExtra.Size = new System.Drawing.Size(227, 161);
            this.grbExtra.TabIndex = 46;
            this.grbExtra.TabStop = false;
            this.grbExtra.Text = "Extra++";
            // 
            // clbExtra
            // 
            this.clbExtra.FormattingEnabled = true;
            this.clbExtra.Location = new System.Drawing.Point(19, 30);
            this.clbExtra.Name = "clbExtra";
            this.clbExtra.Size = new System.Drawing.Size(187, 106);
            this.clbExtra.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Select  Your Saues";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Select  Your Bread";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(6, 357);
            this.dtpOrderDate.MaxDate = new System.DateTime(2023, 9, 22, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(298, 27);
            this.dtpOrderDate.TabIndex = 13;
            this.dtpOrderDate.Value = new System.DateTime(2023, 9, 22, 0, 0, 0, 0);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1028, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbExtra);
            this.Controls.Add(this.grbTpggings);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.grbCheese);
            this.Controls.Add(this.grbMeat);
            this.Controls.Add(this.libSaues);
            this.Controls.Add(this.libBread);
            this.Controls.Add(this.grbCustomerInfo);
            this.Controls.Add(this.cobSandwitchSize);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Sandwich Builder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbCustomerInfo.ResumeLayout(false);
            this.grbCustomerInfo.PerformLayout();
            this.grbMeat.ResumeLayout(false);
            this.grbCheese.ResumeLayout(false);
            this.grbTpggings.ResumeLayout(false);
            this.grbExtra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox grbCustomerInfo;
        private System.Windows.Forms.RadioButton rdbDelivery;
        private System.Windows.Forms.RadioButton rdbPIckUp;
        private System.Windows.Forms.Label lblDeliveryOption;
        private System.Windows.Forms.ComboBox cobSandwitchSize;
        private System.Windows.Forms.ListBox libBread;
        private System.Windows.Forms.ListBox libSaues;
        private System.Windows.Forms.GroupBox grbMeat;
        private System.Windows.Forms.GroupBox grbCheese;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckedListBox clbMeat;
        private System.Windows.Forms.CheckedListBox clbCheese;
        private System.Windows.Forms.GroupBox grbTpggings;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.GroupBox grbExtra;
        private System.Windows.Forms.CheckedListBox clbExtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
    }
}

