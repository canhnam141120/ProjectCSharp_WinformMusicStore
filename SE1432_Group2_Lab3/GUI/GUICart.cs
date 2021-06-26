using SE1432_Group2_Lab3.DAL;
using SE1432_Group2_Lab3.DTL;
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
    public partial class GUICart : Form
    {
        string s;
        public GUICart()
        {
            InitializeComponent();
            if (Variabl.Username == null)
            {
                LoadCart();
            }
            else
            {
                LoadCartUser();
            }
        }

        public GUICart(string s1)
        {
            InitializeComponent();
            this.s = s1;
            if(Variabl.Username == null)
            {
                LoadCart();
            }
            else
            {
                LoadCartUser();
            }
            
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Variabl.Username == null)
            {
                MessageBox.Show("Please Login!");
            }
            else
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Cart empty!");
                }
                else
                {
                    List<OrderDetail> ods = new List<OrderDetail>();
                    DataTable dt = new DataTable();
                    dt = (DataTable)dataGridView1.DataSource;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        OrderDetail o = new OrderDetail();
                        o.AlbumID = int.Parse(dt.Rows[i]["AlbumId"].ToString());
                        o.Quantity = int.Parse(dt.Rows[i]["Count"].ToString());
                        SqlCommand cmd = new SqlCommand("SELECT PRICE FROM Albums WHERE AlbumId =" + o.AlbumID);
                        o.UnitPrice = double.Parse(DAO.GetData(cmd).ToString());
                        ods.Add(o);
                    }
                    GUICheckout c = new GUICheckout(double.Parse(tbTotal.Text), ods);
                    c.ShowDialog();
                    this.Hide();
                }
            }
        }

        public void LoadCart()
        {       
                SqlCommand cmd = new SqlCommand("SELECT SUM(PRICE*Count) FROM Albums inner join Carts on Albums.AlbumId = Carts.AlbumId WHERE Carts.CartId ='" + s + "'");
                object Total = DAO.GetData(cmd);
                tbTotal.Text = Total.ToString();
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Carts WHERE CartId ='" +s+ "'");
                dataGridView1.DataSource = DAO.GetDataTable(cmd2);
                if(ShoppingCartDAO.ShoppingCartId != null)
                {
                SqlCommand cmd3 = new SqlCommand("SELECT SUM(Count) FROM Carts WHERE CartId ='" + s + "'");
                if(dataGridView1.Rows.Count == 0)
                {
                    int TotalCount1 = 0;
                    CountCart.countCart = TotalCount1;
                }if(dataGridView1.Rows.Count > 0)
                {
                    int TotalCount = int.Parse(DAO.GetData(cmd3).ToString());
                    CountCart.countCart = TotalCount;
                }
                }
        }
        public void LoadCartUser()
        {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(PRICE*Count) FROM Albums inner join Carts on Albums.AlbumId = Carts.AlbumId WHERE Carts.CartId ='" + Variabl.Username + "'");
                    object Total = DAO.GetData(cmd);
                    tbTotal.Text = Total.ToString();
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Carts WHERE CartId ='" + Variabl.Username + "'");
                    dataGridView1.DataSource = DAO.GetDataTable(cmd2);
                    SqlCommand cmd3 = new SqlCommand("SELECT SUM(Count) FROM Carts WHERE CartId ='" + Variabl.Username + "'");
                    if (dataGridView1.Rows.Count == 0)
                    {
                        int TotalCount1 = 0;
                        CountCart.countCart = TotalCount1;
                    }
                    if (dataGridView1.Rows.Count > 0)
                    {
                        int TotalCount = int.Parse(DAO.GetData(cmd3).ToString());
                        CountCart.countCart = TotalCount;
                    }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
            {
                int numrow = e.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];

                string sAlbumID = dataGridViewRow.Cells[4].Value.ToString();
                int AlbumID = int.Parse(sAlbumID);

                object title = DAO.GetData(new SqlCommand("SELECT Title from Albums where AlbumId =" + AlbumID));
                object price = DAO.GetData(new SqlCommand("SELECT Price from Albums where AlbumId =" + AlbumID));
                object genreId = DAO.GetData(new SqlCommand("SELECT GenreId from Albums where AlbumId =" + AlbumID));
                object ArtistId = DAO.GetData(new SqlCommand("SELECT ArtistId from Albums where AlbumId =" + AlbumID));
                object sURL = DAO.GetData(new SqlCommand("SELECT AlbumUrl from Albums where AlbumId =" + AlbumID));

                object ArtistName = DAO.GetData(new SqlCommand("SELECT [Name] FROM Artists Where Artists.ArtistId = " + ArtistId));
                object GenreName = DAO.GetData(new SqlCommand("SELECT [Name]  FROM Genres Where GenreId = " + genreId));

                string sTitle = title.ToString();
                double Price = double.Parse(price.ToString());
                string AlbumUrl = sURL.ToString();
                GUIAlbumDetail albumDetailGUI = new GUIAlbumDetail(sTitle, Price, ArtistName, GenreName, AlbumID, AlbumUrl);
                albumDetailGUI.ShowDialog();
                this.Hide();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
            {
                int numrow = e.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];

                string CartId = dataGridViewRow.Cells[2].Value.ToString();
                
                string sAlbumId = dataGridViewRow.Cells[4].Value.ToString();
                int albumId = int.Parse(sAlbumId);

                string sCount = dataGridViewRow.Cells[5].Value.ToString();
                int count = int.Parse(sCount);

                
                if(count > 1)
                {
                    CartDAO.Update(CartId, albumId);
                }
                else
                {
                    CartDAO.Delete(CartId, albumId);
                }
                
                if(Variabl.Username == null)
                {
                    LoadCart();
                }
                else
                {
                    LoadCartUser();
                }
            }
        }

        private void GUICart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
