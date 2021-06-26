using SE1432_Group2_Lab3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE1432_Group2_Lab3
{
    public partial class GUIStore : Form
    {
        public GUIStore()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            if (Variabl.Role == 2)
            {
                lbLogin.Text = $"Logout({Variabl.Username})";
                lbCart.Text = $"Cart({CountCart.countCart})";
            }

            else if (Variabl.Role == 1)
            {
                btnReport.Visible = false;
                lbReport.Visible = false;
                btnAlbum.Visible = false;
                label1.Visible = false;
                lbLogin.Text = $"Logout({Variabl.Username})";
                lbCart.Text = $"Cart({CountCart.countCart})";
            }
            else
            {
                btnReport.Visible = false;
                lbReport.Visible = false;
                btnAlbum.Visible = false;
                label1.Visible = false;
                lbCart.Text = $"Cart({CountCart.countCart})";
            }
        }

        private void Embed(Panel p, Form f)
        {
            p.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);//thêm form mới vào panel
            p.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            GUIAbout f = new GUIAbout();
            Embed(panel1, f);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            GUIShopping f = new GUIShopping();
            Embed(panel1, f);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Variabl.Role >= 1)
            {
                this.Hide();
                Variabl.Role = 0;
                Variabl.Username = null;
                CountCart.countCart = 0;
                GUIStore storeGui = new GUIStore();
                storeGui.ShowDialog();
            }
            else
            {
                this.Hide();
                GUILogin loginGui = new GUILogin();
                loginGui.ShowDialog();
            }
            
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            GUICart cartGui = new GUICart(ShoppingCartDAO.ShoppingCartId);
            cartGui.ShowDialog(this);
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            GUIAlbum f = new GUIAlbum();
            Embed(panel1, f);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            GUIReport f = new GUIReport();
            Embed(panel1, f);
        }

        private void GUIStore_Activated(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
