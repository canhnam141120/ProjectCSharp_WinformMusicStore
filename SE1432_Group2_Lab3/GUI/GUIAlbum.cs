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
    public partial class GUIAlbum : Form
    {
        public GUIAlbum()
        {
            InitializeComponent();
            LoadAlbumList();
        }

        public void LoadAlbumList()
        {
            SqlCommand cmd = new SqlCommand( "SELECT * FROM [dbo].[Albums]");
            dataGridView1.DataSource = DAO.GetDataTable(cmd);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Detail")
            {
                int numrow = e.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];

                String sAlbumID = dataGridViewRow.Cells[0].Value.ToString();
                int AlbumID = int.Parse(sAlbumID);

                String sGenreID = dataGridViewRow.Cells[1].Value.ToString();
                int genreID = int.Parse(sGenreID);

                String sArtistID = dataGridViewRow.Cells[2].Value.ToString();
                int ArtistID = int.Parse(sArtistID);

                String getGenderName = dataGridViewRow.Cells[3].Value.ToString();

                String sPrice = dataGridViewRow.Cells[4].Value.ToString();
                float Price = float.Parse(sPrice);

                String URL = dataGridViewRow.Cells[5].Value.ToString();


                SqlCommand cmd = new SqlCommand("SELECT [Name] FROM Artists Where Artists.ArtistId = " + ArtistID);
                object ArtistName = DAO.GetData(cmd);

                SqlCommand cmd1 = new SqlCommand("SELECT [Name]  FROM Genres Where GenreId = " + genreID);
                object GenreName = DAO.GetData(cmd1);


                GUIAlbumDetail albumDetailGUI = new GUIAlbumDetail(getGenderName, Price, ArtistName, GenreName, AlbumID, URL);
                albumDetailGUI.ShowDialog();
            }


            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                int numrow = e.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];

                string sAlbumId = dataGridViewRow.Cells[0].Value.ToString();
                int albumId = int.Parse(sAlbumId);

                string sGenreID = dataGridViewRow.Cells[1].Value.ToString();
                int genreID = int.Parse(sGenreID);

                string sArtistID = dataGridViewRow.Cells[2].Value.ToString();
                int ArtistID = int.Parse(sArtistID);

                string Title = dataGridViewRow.Cells[3].Value.ToString();

                string sPrice = dataGridViewRow.Cells[4].Value.ToString();
                double Price = double.Parse(sPrice);

                string AlbumUrl = dataGridViewRow.Cells[5].Value.ToString();

                Album a = new Album();
                a.AlbumID = albumId;
                a.GenreID = genreID;
                a.ArtistID = ArtistID;
                a.Title = Title;
                a.Price = Price;
                a.AlbumUrl = AlbumUrl;

                using (GUIAddAlbum editGui = new GUIAddAlbum(a))
                {
                    if(editGui.ShowDialog()== System.Windows.Forms.DialogResult.Yes)
                    {
                        this.LoadAlbumList();
                    }
                }

                /*GUIAddAlbum editGui = new GUIAddAlbum(a);
                editGui.ShowDialog();*/
            }


            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int numrow = e.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];
                String sAlbumId = dataGridViewRow.Cells[0].Value.ToString();
                int albumId = int.Parse(sAlbumId);

                DialogResult result = MessageBox.Show("Do you want to delete this album", "", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    AlbumDAO.Delete(albumId);
                    LoadAlbumList();
                }
            }
        }

        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {

            using (GUIAddAlbum addAlbum = new GUIAddAlbum())
            {
                if (addAlbum.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    this.LoadAlbumList();
                }
            }
        }

        private void GUIAlbum_Activated(object sender, EventArgs e)
        {
            LoadAlbumList();
        }
    }
}
