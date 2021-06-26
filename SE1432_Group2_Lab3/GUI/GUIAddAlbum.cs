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
    public partial class GUIAddAlbum : Form
    {
        
        public GUIAddAlbum()
        {
            InitializeComponent();
        }

        public GUIAddAlbum(Album album)
        {
            InitializeComponent();
            btnEdit.Visible = true;
            LoadEditAlbum(album);
        }

        void LoadEditAlbum(Album a)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Artists ");
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Genres ");
                DataTable ArtistTable = DAO.GetDataTable(cmd);
                DataTable GenreTable = DAO.GetDataTable(cmd1);
                cbGenre.DataSource = GenreTable;
                cbGenre.ValueMember = "GenreId";
                cbGenre.DisplayMember = "Name";
                cbGenre.SelectedValue = a.GenreID;

                cbArtist.DataSource = ArtistTable;
                cbArtist.ValueMember = "ArtistId";
                cbArtist.DisplayMember = "Name";
                cbArtist.SelectedValue = a.ArtistID;

                tbAlbumId.Text = a.AlbumID.ToString();
                tbAddTitle.Text = a.Title;
                tbAddPrice.Text = a.Price.ToString();
                tbAddURL.Text = a.AlbumUrl;
                string path = tbAddURL.Text.Replace('/', '\\');
                pictureBox1.Image = Image.FromFile(getProjectPath() + path);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Not found URL Image!");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = getProjectPath() + "\\Images\\",
                Title = "Select image file",
                Filter = "Gif files (*.gif)|*.gif| Png files (*.png)|*.png",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = openFileDialog.FileName.Substring(openFileDialog.FileName.IndexOf('.'));
                string filename = Guid.NewGuid().ToString() + ext;
                string fileDest = getProjectPath() + "\\Images\\" + filename;
                File.Copy(openFileDialog.FileName, fileDest);

                tbAddURL.Text = "/Images/" + filename;
            }

            string path = tbAddURL.Text.Replace('/', '\\');
            pictureBox1.Image = Image.FromFile(getProjectPath() + path);
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

        private void GUIAddAlbum_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand( "SELECT * FROM Artists ");
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Genres ");
            DataTable ArtistTable = DAO.GetDataTable(cmd);
            DataTable GenreTable = DAO.GetDataTable(cmd1);
            cbGenre.DataSource = GenreTable;
            cbGenre.ValueMember = "GenreId";
            cbGenre.DisplayMember = "Name";
            cbArtist.DataSource = ArtistTable;
            cbArtist.ValueMember = "ArtistId";
            cbArtist.DisplayMember = "Name";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string Title = tbAddTitle.Text;
            int ArtistID = (int)cbArtist.SelectedValue;
            int GenreID = (int)cbGenre.SelectedValue;
            float Price = float.Parse(tbAddPrice.Text);
            string AlbumUrl = tbAddURL.Text;
            Album a = new Album();

            
            a.GenreID = GenreID;
            a.ArtistID = ArtistID;
            a.Title = Title;
            a.Price = Price;
            a.AlbumUrl = AlbumUrl;

            if (AlbumDAO.Insert(a))
            {
                MessageBox.Show("Thêm Album thành công!");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string albumId = tbAlbumId.Text;
            string Title = tbAddTitle.Text;
            int ArtistID = (int)cbArtist.SelectedValue;
            int GenreID = (int)cbGenre.SelectedValue;
            double Price = double.Parse(tbAddPrice.Text);
            string AlbumUrl = tbAddURL.Text;
            Album a = new Album();
            a.AlbumID = int.Parse(albumId);
            a.GenreID = GenreID;
            a.ArtistID = ArtistID;
            a.Title = Title;
            a.Price = Price;
            a.AlbumUrl = AlbumUrl;
            AlbumDAO.Update(a);
            this.Hide();
            
            /*if (AlbumDAO.Update(a))
            {
                MessageBox.Show("Edit album thành công!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }*/
        }
    }
}
