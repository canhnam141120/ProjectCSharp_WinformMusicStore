
namespace SE1432_Group2_Lab3
{
    partial class GUICheckout
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tbPromocode = new System.Windows.Forms.TextBox();
            this.lbPromocode = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.ttxAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 5, 1, 19, 29, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 33);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(119, 453);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(84, 33);
            this.btnOrder.TabIndex = 52;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tbPromocode
            // 
            this.tbPromocode.Location = new System.Drawing.Point(151, 416);
            this.tbPromocode.Name = "tbPromocode";
            this.tbPromocode.ReadOnly = true;
            this.tbPromocode.Size = new System.Drawing.Size(275, 22);
            this.tbPromocode.TabIndex = 51;
            this.tbPromocode.Text = "FREE";
            // 
            // lbPromocode
            // 
            this.lbPromocode.AutoSize = true;
            this.lbPromocode.Location = new System.Drawing.Point(43, 416);
            this.lbPromocode.Name = "lbPromocode";
            this.lbPromocode.Size = new System.Drawing.Size(84, 17);
            this.lbPromocode.TabIndex = 50;
            this.lbPromocode.Text = "Promocode:";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(43, 396);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(466, 17);
            this.lbNote.TabIndex = 49;
            this.lbNote.Text = "We\'re running a promotion: all music is free with the prome code: \"FREE\"";
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(151, 354);
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(275, 22);
            this.txTotal.TabIndex = 48;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(83, 353);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 17);
            this.lbTotal.TabIndex = 47;
            this.lbTotal.Text = "Total:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(151, 325);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(275, 22);
            this.tbEmail.TabIndex = 46;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(81, 325);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 17);
            this.lbEmail.TabIndex = 45;
            this.lbEmail.Text = "Email:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(151, 295);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(275, 22);
            this.tbPhone.TabIndex = 44;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(74, 295);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(53, 17);
            this.lbPhone.TabIndex = 43;
            this.lbPhone.Text = "Phone:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 22);
            this.textBox2.TabIndex = 42;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(66, 263);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(61, 17);
            this.lbCountry.TabIndex = 41;
            this.lbCountry.Text = "Country:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 22);
            this.textBox1.TabIndex = 40;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(82, 226);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(45, 17);
            this.lbState.TabIndex = 39;
            this.lbState.Text = "State:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(151, 191);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(275, 22);
            this.tbCity.TabIndex = 38;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(92, 196);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(35, 17);
            this.lbCity.TabIndex = 37;
            this.lbCity.Text = "City:";
            // 
            // ttxAddress
            // 
            this.ttxAddress.Location = new System.Drawing.Point(151, 153);
            this.ttxAddress.Name = "ttxAddress";
            this.ttxAddress.Size = new System.Drawing.Size(275, 22);
            this.ttxAddress.TabIndex = 36;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(63, 156);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(64, 17);
            this.lbAddress.TabIndex = 35;
            this.lbAddress.Text = "Address:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(151, 117);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(275, 22);
            this.tbLastName.TabIndex = 34;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(49, 122);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(78, 17);
            this.lbLastName.TabIndex = 33;
            this.lbLastName.Text = "Last name:";
            // 
            // txFirstName
            // 
            this.txFirstName.Location = new System.Drawing.Point(151, 83);
            this.txFirstName.Name = "txFirstName";
            this.txFirstName.Size = new System.Drawing.Size(275, 22);
            this.txFirstName.TabIndex = 32;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(49, 86);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(78, 17);
            this.lbFirstName.TabIndex = 31;
            this.lbFirstName.Text = "First name:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(151, 53);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(275, 22);
            this.tbUserName.TabIndex = 30;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(46, 53);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(81, 17);
            this.lbUserName.TabIndex = 29;
            this.lbUserName.Text = "User name:";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(46, 22);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(81, 17);
            this.lbOrderDate.TabIndex = 28;
            this.lbOrderDate.Text = "Order date:";
            // 
            // GUICheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 497);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.tbPromocode);
            this.Controls.Add(this.lbPromocode);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.ttxAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.txFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbOrderDate);
            this.Name = "GUICheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUICheckout";
            this.Load += new System.EventHandler(this.GUICheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbPromocode;
        private System.Windows.Forms.Label lbPromocode;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox ttxAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbOrderDate;
    }
}