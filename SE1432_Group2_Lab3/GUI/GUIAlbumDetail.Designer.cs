
namespace SE1432_Group2_Lab3
{
    partial class GUIAlbumDetail
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbAlbumId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(174, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Location = new System.Drawing.Point(309, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 27);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AutoSize = true;
            this.btnAddToCart.Location = new System.Drawing.Point(109, 314);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(96, 27);
            this.btnAddToCart.TabIndex = 19;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(195, 259);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 22);
            this.tbGenre.TabIndex = 18;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(195, 220);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(82, 22);
            this.tbArtist.TabIndex = 17;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(195, 175);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(143, 22);
            this.tbPrice.TabIndex = 16;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(195, 134);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(190, 22);
            this.tbTitle.TabIndex = 15;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(106, 259);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(52, 17);
            this.lbGenre.TabIndex = 14;
            this.lbGenre.Text = "Genre:";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Location = new System.Drawing.Point(114, 223);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(44, 17);
            this.lbArtist.TabIndex = 13;
            this.lbArtist.Text = "Artist:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(114, 180);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 17);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(114, 139);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(39, 17);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "Title:";
            // 
            // tbAlbumId
            // 
            this.tbAlbumId.Location = new System.Drawing.Point(13, 351);
            this.tbAlbumId.Name = "tbAlbumId";
            this.tbAlbumId.Size = new System.Drawing.Size(54, 22);
            this.tbAlbumId.TabIndex = 22;
            this.tbAlbumId.Visible = false;
            // 
            // GUIAlbumDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 385);
            this.Controls.Add(this.tbAlbumId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbTitle);
            this.Name = "GUIAlbumDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUIAlbumDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbAlbumId;
    }
}