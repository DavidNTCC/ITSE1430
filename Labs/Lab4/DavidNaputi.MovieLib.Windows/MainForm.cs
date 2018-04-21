/*
 *  MainForm.cs
 *  David Naputi
 *  ITSE 1430 MW 7:30
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DavidNaputi.MovieLib.Data;
using DavidNaputi.MovieLib.Data.Memory;

namespace DavidNaputi.MovieLib.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load( object sender, EventArgs e )
        {

        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _database = new MemoryMovieDatabase();

            RefreshUI();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var button = sender as ToolStripMenuItem;

            var form = new MovieDetailForm("Add Movie");

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //Add to database
            //_database.Add(form.Movie);
            //if (!String.IsNullOrEmpty(message))
            //    MessageBox.Show(message);

            try
            {
                _database.Add(form.Movie);
            } catch (NotImplementedException)
            {
                MessageBox.Show("Not implemented");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

            RefreshUI();

            /*
            var form = new MovieDetailForm();
            form.Text = "Add Movie";
            
            var result = form.ShowDialog();
            if (result != DialogResult.OK)
                return;

            _movie = form.Movie;
            */
        }

        //Called when a cell is double clicked
        private void OnCellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        //Called when a key is pressed while in a cell
        private void OnCellKeyDown( object sender, KeyEventArgs e )
        {

        }

        private void OnMovieEdit( object sender, EventArgs e )
        {
            
            //Get selected movie
            var movie = GetSelectedMovie();
            if (movie == null)
            {
                MessageBox.Show(this, "No movie selected", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            EditMovie(movie);
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
            //Get selected movie
            var movie = GetSelectedMovie();
            if (movie == null)
            {
                MessageBox.Show(this, "No movie selected", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            DeleteMovie(movie);

            /*if (_movie != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the movie?", "Deleting Movie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    _movie = null;
                else
                    return;
            }*/
        }

        #region Private Members

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
            //_database.Update(form.Movie, out var message);
            //if (!String.IsNullOrEmpty(message))
            //    MessageBox.Show(message);

            try
            {
                _database.Update(form.Movie);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            };

            RefreshUI();
        }

        private Movie GetSelectedMovie()
        {
            var items = (from r in movieDataGridView.SelectedRows.OfType<DataGridViewRow>()
                         select new {
                             Index = r.Index,
                             Movie = r.DataBoundItem as Movie
                         }).FirstOrDefault();

            return items.Movie;
        }

        private void RefreshUI()
        {
            
            //Get products
            IEnumerable<Movie> movies = null;
            try
            {
                movies = _database.GetAll();
            } catch (Exception)
            {
                MessageBox.Show("Error loading movies");
            };

            movieBindingSource.DataSource = movies?.ToList();
            
            /*
            //Get movies
            var movies = _database.GetAll();
            //movies[0].Name = "Movie A";

            //Bind to grid
            //movieBindingSource.DataSource = new List<Movie>(movies);
            //movieBindingSource.DataSource = Enumerable.ToList(movies);
            movieBindingSource.DataSource = movies.ToList();
            //dataGridView1.DataSource
            */
        }

        private bool ShowConfirmation( string message, string title )
        {
            return MessageBox.Show(this, message, title
                             , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                           == DialogResult.Yes;
        }

        private IMovieDatabase _database = new MemoryMovieDatabase();

        

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void _mainMenu_ItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {

        }

        private void movieDataGridView_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void movieDataGridView_Load( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void movieBindingSource_CurrentChanged( object sender, EventArgs e )
        {

        }

        //private Movie _movie;
        #endregion
    }
}
