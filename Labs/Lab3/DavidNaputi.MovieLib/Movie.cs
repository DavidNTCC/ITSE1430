/*
 *  Movie.cs
 *  David Naputi
 *  ITSE 1430 MW 7:30
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace DavidNaputi.MovieLib
{
    public class Movie : IValidatableObject
    {
        /// <summary>get or set the movie ID</summary>
        public int Id { get; set; }

        /// <summary>Get or set the title</summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>Get or set the description</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value ?? ""; }
        }

        /// <summary>Get or set the length</summary>
        public int Length { get; set; } = 0;

        /// <summary>Get or set the ownership status</summary>
        public bool IsOwned { get; set; }

        /// <summary>Validate the movie.</summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>The validation results.</returns>
        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var errors = new List<ValidationResult>();

            //Title is required
            if (String.IsNullOrEmpty(Title))
                errors.Add(new ValidationResult("Name cannot be empty",
                             new[] { nameof(Title) }));

            //Price >= 0
            if (Length < 0)
                errors.Add(new ValidationResult("Length must be >= 0",
                            new[] { nameof(Length) }));

            return errors;
        }

        //public static bool Editing{ get; set; }

        private string _title;
        private string _description;

        DataGridViewTextBoxColumn _titleColumn = new DataGridViewTextBoxColumn() { Name = "Title", DataPropertyName = "Title" };

        DataGridViewTextBoxColumn _descriptionColumn = new DataGridViewTextBoxColumn() { Name = "Title", DataPropertyName = "Title" };

        DataGridViewTextBoxColumn _lengthColumn = new DataGridViewTextBoxColumn() { Name = "Title", DataPropertyName = "Title" };

        DataGridViewCheckBoxColumn _ownedColumn = new DataGridViewCheckBoxColumn() { Name = "Owned", DataPropertyName = "IsOwned" };

        DataGridViewTextBoxColumn _idColumn = new DataGridViewTextBoxColumn() { Name = "Title", DataPropertyName = "Id" };

        
    }
}
