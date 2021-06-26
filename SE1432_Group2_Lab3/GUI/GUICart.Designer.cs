
namespace SE1432_Group2_Lab3
{
    partial class GUICart
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCheckout = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail,
            this.recordIDDataGridViewTextBoxColumn,
            this.cartIDDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.albumIDDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.Remove});
            this.dataGridView1.DataSource = this.cartBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(53, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detail.Text = "Detail";
            this.Detail.UseColumnTextForButtonValue = true;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cartIDDataGridViewTextBoxColumn
            // 
            this.cartIDDataGridViewTextBoxColumn.DataPropertyName = "CartID";
            this.cartIDDataGridViewTextBoxColumn.HeaderText = "CartID";
            this.cartIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cartIDDataGridViewTextBoxColumn.Name = "cartIDDataGridViewTextBoxColumn";
            this.cartIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cartIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumIDDataGridViewTextBoxColumn
            // 
            this.albumIDDataGridViewTextBoxColumn.DataPropertyName = "AlbumID";
            this.albumIDDataGridViewTextBoxColumn.HeaderText = "AlbumID";
            this.albumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.albumIDDataGridViewTextBoxColumn.Name = "albumIDDataGridViewTextBoxColumn";
            this.albumIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // cartBindingSource1
            // 
            this.cartBindingSource1.DataSource = typeof(SE1432_Group2_Lab3.DTL.Cart);
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckout.Location = new System.Drawing.Point(53, 19);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(114, 30);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout >>";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(632, 27);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 22);
            this.tbTotal.TabIndex = 5;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(566, 30);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 17);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total:";
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataSource = typeof(SE1432_Group2_Lab3.DTL.Cart);
            // 
            // GUICart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbTotal);
            this.Name = "GUICart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUICart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUICart_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private System.Windows.Forms.BindingSource cartBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}