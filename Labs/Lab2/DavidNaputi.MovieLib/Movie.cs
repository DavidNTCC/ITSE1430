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

namespace DavidNaputi.MovieLib
{
    public class Movie
    {
        /// <summary></summary>
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

        /// <summary></summary>
        public int Length { get; set; } = 0;

        /// <summary></summary>
        public bool IsOwned { get; set; }

        public string Validate()
        {
            //Name is required
            if (String.IsNullOrEmpty(Title))
                return "Name cannot be empty";

            //Price >= 0
            if (Length < 0)
                return "Length must be >= 0";

            return "";
        }

        public static bool Editing{ get; set; }

        private string _title;
        private string _description;

    }
}
