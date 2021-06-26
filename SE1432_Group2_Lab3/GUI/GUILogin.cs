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
    public partial class GUILogin : Form
    {
        public GUILogin()
        {
            InitializeComponent();
        }

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIStore storeGUI = new GUIStore();
            storeGUI.Show();
        }

        private void btnLoginMain_Click(object sender, EventArgs e)
        {
            
            string username = tbName.Text;
            string password = tbPassword.Text;
            
            if (Login(username, password))
            {
                SqlCommand cmd = new SqlCommand("SELECT Role FROM Users WHERE Username='" + username + "' and Password='" + password + "'");
                Variabl.Role = DAO.GetRole(cmd) +1;
                Variabl.Username = username;
                if(ShoppingCartDAO.ShoppingCartId != null)
                {
                    CartDAO.MigrateCart(ShoppingCartDAO.ShoppingCartId, Variabl.Username);

                    SqlCommand cmd3 = new SqlCommand("SELECT SUM(Count) FROM Carts WHERE CartId ='" + Variabl.Username + "'");
                    object a = DAO.GetData(cmd3);
                    if (a.ToString() == null)
                    {
                        CountCart.countCart = 0;
                    }
                    else
                    {
                        int TotalCount = int.Parse(a.ToString());
                        CountCart.countCart = TotalCount;
                    }
                }
                this.Hide();
                GUIStore storeGui = new GUIStore();
                storeGui.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        }

        bool Login(string username, string password)
        {
            return UserDAO.Instance.Login(username, password);
        }
         
    }
}
