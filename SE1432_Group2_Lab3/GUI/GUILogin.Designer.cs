
namespace SE1432_Group2_Lab3
{
    partial class GUILogin
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
            this.btnCancelMain = new System.Windows.Forms.Button();
            this.btnLoginMain = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelMain
            // 
            this.btnCancelMain.Location = new System.Drawing.Point(238, 165);
            this.btnCancelMain.Name = "btnCancelMain";
            this.btnCancelMain.Size = new System.Drawing.Size(75, 37);
            this.btnCancelMain.TabIndex = 11;
            this.btnCancelMain.Text = "Cancel";
            this.btnCancelMain.UseVisualStyleBackColor = true;
            this.btnCancelMain.Click += new System.EventHandler(this.btnCancelMain_Click);
            // 
            // btnLoginMain
            // 
            this.btnLoginMain.Location = new System.Drawing.Point(108, 165);
            this.btnLoginMain.Name = "btnLoginMain";
            this.btnLoginMain.Size = new System.Drawing.Size(75, 37);
            this.btnLoginMain.TabIndex = 10;
            this.btnLoginMain.Text = "Login";
            this.btnLoginMain.UseVisualStyleBackColor = true;
            this.btnLoginMain.Click += new System.EventHandler(this.btnLoginMain_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(160, 96);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(162, 22);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(160, 55);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(162, 22);
            this.tbName.TabIndex = 8;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(74, 96);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(73, 17);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(74, 55);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name:";
            // 
            // GUILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 285);
            this.Controls.Add(this.btnCancelMain);
            this.Controls.Add(this.btnLoginMain);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbName);
            this.Name = "GUILogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUILogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelMain;
        private System.Windows.Forms.Button btnLoginMain;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbName;
    }
}