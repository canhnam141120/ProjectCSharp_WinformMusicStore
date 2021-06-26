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
    public partial class GUIShopping : Form
    {
       
        public GUIShopping()
        {
            InitializeComponent();
            loadData();
        }


        void loadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT GenreId, Name AS genName FROM dbo.Genres");
            DataTable dtGenreCombobox = DAO.GetDataTable(cmd);
            dataGridView1.DataSource = dtGenreCombobox;
            dataGridView1.Columns["GenreId"].Visible = false;
            string query = "SELECT * FROM Albums WHERE GenreId = 1";
            dataGridView2.DataSource = DAO.GetDataTable(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];
            string getGenderName = dataGridViewRow.Cells[1].Value.ToString();
            string query = "SELECT * FROM Albums WHERE GenreId = (SELECT GenreId FROM Genres where[Name] = '" + getGenderName + "')";
            dataGridView2.DataSource = DAO.GetDataTable(query);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Detail")
            {
                int numrow = e.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView2.Rows[numrow];

                string sAlbumID = dataGridViewRow.Cells[1].Value.ToString();
                int AlbumID = int.Parse(sAlbumID);

                string sGenreID = dataGridViewRow.Cells[2].Value.ToString();
                int genreID = int.Parse(sGenreID);

                string sArtistID = dataGridViewRow.Cells[3].Value.ToString();
                int ArtistID = int.Parse(sArtistID);

                string getGenderName = dataGridViewRow.Cells[4].Value.ToString();

                string sPrice = dataGridViewRow.Cells[5].Value.ToString();
                double Price = double.Parse(sPrice);

                string URL = dataGridViewRow.Cells[6].Value.ToString();

                
                SqlCommand cmd = new SqlCommand("SELECT [Name] FROM Artists Where Artists.ArtistId = " + ArtistID);
                object ArtistName = DAO.GetData(cmd);

                SqlCommand cmd1 = new SqlCommand("SELECT [Name]  FROM Genres Where GenreId = " + genreID);
                object GenreName = DAO.GetData(cmd1);


                GUIAlbumDetail albumDetailGUI = new GUIAlbumDetail(getGenderName, Price, ArtistName, GenreName, AlbumID, URL);
                albumDetailGUI.ShowDialog();
            }
        }
    }
}
