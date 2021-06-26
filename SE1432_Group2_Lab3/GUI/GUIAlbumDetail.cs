using SE1432_Group2_Lab3.DAL;
using SE1432_Group2_Lab3.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE1432_Group2_Lab3
{
    public partial class GUIAlbumDetail : Form
    {
        int AlbumID;
        private string Title;
        private double Price;
        private object ArtistName;
        private object GenreName;
        private string URL;
        public GUIAlbumDetail()
        {
            InitializeComponent();
        }
        public GUIAlbumDetail(string Title, double Price, object ArtistName, object GenreName, int AlbumID, string URL)
        {
            InitializeComponent();
            this.AlbumID = AlbumID;
            this.Title = Title;
            this.Title = Title;
            this.Price = Price;
            this.ArtistName = ArtistName;
            this.GenreName = GenreName;
            this.URL = URL;
            LoadDetail();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void LoadDetail()
        {

            try {
                tbAlbumId.Text = AlbumID.ToString();
                tbTitle.Text = Title;
                tbPrice.Text = Price.ToString();
                tbArtist.Text = ArtistName.ToString();
                tbGenre.Text = GenreName.ToString();
                pictureBox1.Image = Image.FromFile(getProjectPath() + URL);
            }
            
            catch (Exception ex)
            {
                
                MessageBox.Show("Not found URL Image!");
            }
        }

        private string getProjectPath()
        {
            string path = Application.StartupPath;
            DirectoryInfo di = new DirectoryInfo(path);
            for (int i = 0; i < 2; i++)
            {
                di = Directory.GetParent(di.FullName);
            }
            return di.FullName;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            ShoppingCartDAO scd = new ShoppingCartDAO();
            DateTime now = DateTime.Now;
            Cart c = new Cart();
            ShoppingCartDAO.ShoppingCartId = scd.GetCartId();
            c.AlbumID = AlbumID;
            if (Variabl.Username != null)
            {
                c.CartID = Variabl.Username;
                /*SqlCommand cmd1 = new SqlCommand("UPDATE [Carts] SET CartId = '" + c.CartID + "' WHERE CartId = '" + ShoppingCartDAO.ShoppingCartId + "'");
                DAO.UpdateTable(cmd1);*/
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Carts WHERE CartId = '" + c.CartID + "' and AlbumId =" + c.AlbumID);
                DataTable data1 = DAO.GetDataTable(cmd2);

                if (data1.Rows.Count == 0)
                {
                    c.Count = 1;
                    c.DateCreated = now;
                    CartDAO.Insert(c);
                }
                else
                {
                    CartDAO.Update(c);
                }
            }
            if(Variabl.Username == null) {
                c.CartID = ShoppingCartDAO.ShoppingCartId;
                SqlCommand cmd = new SqlCommand("SELECT * FROM Carts WHERE CartId = '" + c.CartID + "' and AlbumId =" + c.AlbumID);
                DataTable data = DAO.GetDataTable(cmd);

            if (data.Rows.Count == 0)
            {
                c.Count = 1;
                c.DateCreated = now;
                CartDAO.Insert(c);
            }
            else
            {
                CartDAO.Update(c);
            }
            }
            GUICart cartGui = new GUICart(scd.GetCartId());
            cartGui.ShowDialog();
            this.Hide();
        }
    }
}
