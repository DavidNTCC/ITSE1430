/*
 *  MainForm.cs
 *  David Naputi
 *  ITSE 1430 MW 7:30
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var form = new MovieDetails();
            form.Text = "Add Movie";
            
            var result = form.ShowDialog();
            if (result != DialogResult.OK)
                return;

            _movie = form.MovieEntry;
        }

        private void OnMovieEdit( object sender, EventArgs e )
        {
            if (_movie != null)
            {
                Movie.Editing = true;
                var form = new MovieDetails();
                form.Text = "Edit Movie";
                form.MovieEntry = _movie;

                var result = form.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                Movie.Editing = false;
                _movie = form.MovieEntry;
            } else
                MessageBox.Show(this, "No movie available to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
            if (_movie != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the movie?", "Deleting Movie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    _movie = null;
                else
                    return;
            }
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            System.Windows.Forms.Application.Exit();
        }
        private Movie _movie;
    }
}
