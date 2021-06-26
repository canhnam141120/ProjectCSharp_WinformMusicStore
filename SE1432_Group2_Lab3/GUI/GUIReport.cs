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
    public partial class GUIReport : Form
    {
        public GUIReport()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT [OrderId],[OrderDate],[Promocode],[Username],[FirstName],[LastName],[Address],[City],[State],[Country],[Phone],[Email],[Total] FROM dbo.Orders");
            DataTable dt = DAO.GetDataTable(cmd);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];
            int orderId = int.Parse(dataGridViewRow.Cells[0].Value.ToString());
            string oDate = dataGridViewRow.Cells[1].Value.ToString();
            DateTime Date = Convert.ToDateTime(oDate);
            string oFirstName = dataGridViewRow.Cells[4].Value.ToString();
            string oCountry = dataGridViewRow.Cells[9].Value.ToString();

            monthCalendar1.SetDate(Date);
            tbFrom.Text = Date.ToString("MM/dd/yyyy");
            tbTo.Text = Date.ToString("MM/dd/yyyy");
            tbFirstName1.Text = oFirstName;
            tbCountry1.Text = oCountry;

            SqlCommand cmd = new SqlCommand( "SELECT * FROM OrderDetails WHERE OrderId =" + orderId);
            DAO dao = new DAO();
            dataGridView2.DataSource = DAO.GetDataTable(cmd);
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            DateTime dateFrom = monthCalendar1.SelectionStart;
            tbFrom.Text = dateFrom.ToString("MM/dd/yyyy");
            DateTime dateTo = monthCalendar1.SelectionEnd;
            tbTo.Text = dateTo.ToString("MM/dd/yyyy");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string from = tbFrom.Text;
            string to = tbTo.Text;
            string firstname = tbFirstName1.Text;
            string country = tbCountry1.Text;

                SqlCommand cmd = new SqlCommand("SELECT [OrderId],[OrderDate],[Promocode],[Username],[FirstName],[LastName],[Address],[City],[State],[Country],[Phone],[Email],[Total] FROM [dbo].[Orders] WHERE OrderDate between '" + from + "' and '" + to + "' and FirstName like '%%" + firstname + "%%'  and Country like '%%" + country + "%%'");
                dataGridView1.DataSource = DAO.GetDataTable(cmd);
                dataGridView2.DataSource = null;
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
