using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1432_Group2_Lab3.DTL
{
    public class Album
    {
        private int albumID;

        public int AlbumID
        {
            get { return albumID; }
            set { albumID = value; }
        }

        private int genreID;

        public int GenreID
        {
            get { return genreID; }
            set { genreID = value; }
        }
        private int artistID;

        public int ArtistID
        {
            get { return artistID; }
            set { artistID = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private string albumUrl;

        public string AlbumUrl
        {
            get { return albumUrl; }
            set { albumUrl = value; }
        }
    }
}
