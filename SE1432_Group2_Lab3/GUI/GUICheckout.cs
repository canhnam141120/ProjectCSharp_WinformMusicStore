using SE1432_Group2_Lab3.DAL;
using SE1432_Group2_Lab3.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE1432_Group2_Lab3
{
    
    public partial class GUICheckout : Form
    {
        private double total;
        private List<OrderDetail> ods;
        public GUICheckout()
        {
            InitializeComponent();
        }

        public GUICheckout(double total, List<OrderDetail> ods)
        {
            InitializeComponent();
            this.total = total;
            txTotal.Text = total.ToString();
            this.ods = ods;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GUICheckout_Load(object sender, EventArgs e)
        {
            tbUserName.Text = Variabl.Username;
            UserInfo uI = UserDAO.Instance.getInfo(Variabl.Username);
            txFirstName.Text = uI.FirstName;
            tbLastName.Text = uI.LastName;
            ttxAddress.Text = uI.Address;
            tbCity.Text = uI.City;
            textBox1.Text = uI.State;
            textBox2.Text = uI.Country;
            tbPhone.Text = uI.Phone;
            tbEmail.Text = uI.Email;
            txTotal.Text = total.ToString();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!checkTxtBox(txFirstName))
            {
                MessageBox.Show("First Name is empty!");
                cancelResult();
            }
            else if (!checkTxtBox(tbLastName))
            {
                MessageBox.Show("Last Name is empty!");
                cancelResult();
            }
            else if (!checkTxtBox(tbEmail))
            {
                MessageBox.Show("Email is empty!");
                cancelResult();
            }
            else
            {
                Order o = new Order();
                o.UserName = tbUserName.Text;
                o.OrderID = OrderDAO.GetMaxID();
                o.OrderDate = dateTimePicker1.Value;
                o.FirstName = txFirstName.Text;
                o.Lastname = tbLastName.Text;
                o.Address = ttxAddress.Text;
                o.City = tbCity.Text;
                o.State = textBox1.Text;
                o.Country = textBox2.Text;
                o.Phone = tbPhone.Text;
                o.Email = tbEmail.Text;
                o.PromoCode = tbPromocode.Text;
                o.Total = double.Parse(txTotal.Text);

                if (OrderDAO.Insert(o))
                {
                    int orderID = OrderDAO.GetMaxID();
                    foreach (OrderDetail ot in ods)
                    {
                        ot.OrderID = orderID;
                        OrderDetailDAO.Insert(ot);
                    }

                    MessageBox.Show("Add Order(" + orderID.ToString() + ") successfully!");
                    this.Close();
                }
                else
                {
                    cancelResult();
                }
            }
            CountCart.countCart = 0;
            CartDAO.Delete(Variabl.Username);
        }

        private Boolean checkTxtBox(TextBox tx)
        {
            if (tx.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void cancelResult()
        {
            this.DialogResult = DialogResult.None;

        }
    }
}
