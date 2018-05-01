/*
 *  MovieDetails.cs
 *  David Naputi
 *  ITSE 1430 MW 7:30
 */
using System;
using System.Linq;
using System.Windows.Forms;

namespace DavidNaputi.MovieLib.Windows
{
    /// <summary>Gets or sets the movie being edited.</summary>
    public partial class MovieDetailForm : Form
    {
        public Movie Movie { get; set; }

        public MovieDetailForm()
        {
            InitializeComponent();
            //Shown += MovieDetails_Shown;
        }

        public MovieDetailForm( string title ) : this()
        {
            Text = title;
        }

        public MovieDetailForm( Movie movie ) : this("Edit Movie")
        {
            Movie = Movie;
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Movie != null) //If the movie exists, then fill in the text boxes and checkbox accordingly
            {
                _txtTitle.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtLength.Text = Movie.Length.ToString();
                _chkOwned.Checked = Movie.IsOwned;
            }
            ValidateChildren();
        }

        private void textBox3_TextChanged( object sender, EventArgs e )
        {

        }

        private void MovieDetails_Load( object sender, EventArgs e )
        {
            //if (MovieEntry.Title != null && Movie.Editing == true) //If the movie exists, then fill in the text boxes and checkbox accordingly
            //{
            //    _txtTitle.Text = MovieEntry.Title;
            //    _txtDescription.Text = MovieEntry.Description;
            //    _txtLength.Text = MovieEntry.Length.ToString();
            //    _chkOwned.Checked = MovieEntry.IsOwned;
            //}
        }

        private void MovieDetails_Shown( object sender, EventArgs e )
        {
            
            /*if (Movie.Editing == true && !String.IsNullOrEmpty(MovieEntry.Title))
            {
            _txtTitle.Text = MovieEntry.Title;
            _txtDescription.Text = MovieEntry.Description;
            _txtLength.Text = MovieEntry.Length.ToString();
            _chkOwned.Checked = MovieEntry.IsOwned;
            }*/
        }

        private void DisplayError( string message )
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void _txtTitle_Validating( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text))
            {

                _errorProvider.SetError(textbox, "Title is required");
                e.Cancel = true;
            } else
                _errorProvider.SetError(textbox, "");
        }

        private void _txtLength_Validating( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var textbox = sender as TextBox;

            var price = ConvertToLength(textbox);
            if (price < 0)
            {
                _errorProvider.SetError(textbox, "Length must be >= 0");
                e.Cancel = true;
            } else
                _errorProvider.SetError(textbox, "");
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
            /*
            //Create movie
            var movie = new Movie();

            //set properties
            movie.Title = _txtTitle.Text;
            movie.Description = _txtDescription.Text;
            movie.Length = ConvertToLength(_txtLength);
            movie.IsOwned = _chkOwned.Checked;

            if (String.IsNullOrEmpty(movie.Title))
                MessageBox.Show(this, "Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (movie.Length < 0)
                MessageBox.Show(this, "Length must be a number greater than or equal to 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!String.IsNullOrEmpty(movie.Title) && movie.Length >= 0) //Validate the data entered
            {
                Movie = movie;
                DialogResult = DialogResult.OK;
                Close();
            }
            */

            //Force validation of child controls
            if (!ValidateChildren())
                return;

            // Create movie - using object initializer syntax
            var movie = new Movie() {
                Title = _txtTitle.Text,
                Description = _txtDescription.Text,
                Length = ConvertToLength(_txtLength),
                IsOwned = _chkOwned.Checked,
            };

            //Validate movie using IValidatableObject
            var errors = ObjectValidator.TryValidate(movie);
            if (errors.Count() > 0)
            {
                //Get first error
                DisplayError(errors.ElementAt(0).ErrorMessage);
                return;
            };

            //Return from form
            Movie = movie;
            DialogResult = DialogResult.OK;

            Close();
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

        /*#region Private Members

        //Helper method to handle deleting movies
        private void DeleteMovie( Movie movie )
        {
            if (!ShowConfirmation("Are you sure?", "Remove Movie"))
                return;

            //Remove movie
            _database.Remove(movie.Id);

            RefreshUI();
        }

        //Helper method to handle editing movies
        private void EditMovie( Movie movie )
        {
            var form = new MovieDetailForm(movie);
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //Update the movie
            form.Movie.Id = movie.Id;
            _database.Update(form.Movie, out var message);
            if (!String.IsNullOrEmpty(message))
                MessageBox.Show(message);

            RefreshUI();
        }

        private Movie GetSelectedMovie()
        {
            //TODO: Use the binding source
            //Get the first selected row in the grid, if any
            if (dataGridView1.SelectedRows.Count > 0)
                return dataGridView1.SelectedRows[0].DataBoundItem as Movie;

            return null;
        }

        private void RefreshUI()
        {
            //Get movies
            var movies = _database.GetAll();
            //movies[0].Name = "Movie A";

            //Bind to grid
            //movieBindingSource.DataSource = new List<Movie>(movies);
            //movieBindingSource.DataSource = Enumerable.ToList(movies);
            movieBindingSource.DataSource = movies.ToList();
            //dataGridView1.DataSource 
        }

        private bool ShowConfirmation( string message, string title )
        {
            return MessageBox.Show(this, message, title
                             , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                           == DialogResult.Yes;
        }

        private IMovieDatabase _database = new MemoryMovieDatabase();

        #endregion*/
    }
}
