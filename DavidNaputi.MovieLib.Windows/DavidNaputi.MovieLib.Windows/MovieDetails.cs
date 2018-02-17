/*
 *  MovieDetails.cs
 *  David Naputi
 *  ITSE 1430 MW 7:30
 */
using System;
using System.Windows.Forms;

namespace DavidNaputi.MovieLib.Windows
{
    public partial class MovieDetails : Form
    {
        public MovieDetails()
        {
            InitializeComponent();
        }

        public Movie MovieEntry { get; set; }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);
            if (!String.IsNullOrEmpty(MovieEntry.Title))
            {
                _txtTitle.Text = MovieEntry.Title;
                _txtDescription.Text = MovieEntry.Description;
                _txtLength.Text = MovieEntry.Length.ToString();
                _chkOwned.Checked = MovieEntry.IsOwned;
            }
        }

        private void textBox3_TextChanged( object sender, EventArgs e )
        {

        }

        private void MovieDetails_Load( object sender, EventArgs e )
        {
            
        }

        private void label1_Click( object sender, EventArgs e )
        {

        }

        private void TextTitle( object sender, EventArgs e )
        {

        }

        private void label2_Click( object sender, EventArgs e )
        {

        }

        private void label3_Click( object sender, EventArgs e )
        {

        }

        private void textBox4_TextChanged( object sender, EventArgs e )
        {

        }

        private void CheckBoxIsOwned( object sender, EventArgs e )
        {

        }

        private void OnSave( object sender, EventArgs e )
        {
            //Create movie
            var movie = new Movie();

            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Length = ConvertToLength(_txtLength);
            movie.IsOwned = _chkOwned.Checked;

            if (String.IsNullOrEmpty(movie.Title))
                MessageBox.Show(this, "Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (movie.Length < 0)
                MessageBox.Show(this, "Length must be a number greater than or equal to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!String.IsNullOrEmpty(movie.Title) && movie.Length >= 0)
            {
                MovieEntry = movie;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private int ConvertToLength( TextBox control )
        {
            if (Int32.TryParse(control.Text, out var length) && length >= 0)
                return length;

            return -1;
        }

        private void OnCancel( object sender, EventArgs e )
        {

        }       
    }
}
