using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while (!quit)
            {
                //Display menu
                char choice = DisplayMenu();

                //Process menu selection
                switch (Char.ToUpper(choice))
                {
                    case 'L':
                    ListMovies(); break;

                    case 'A':
                    AddMovie(); break;

                    case 'R':
                    RemoveMovie(); break;

                    case 'Q':
                    quit = true; break;
                }
            };
        }
        static void AddMovie()
        {
            //Get name
            _title = ReadString("Enter a title: ", true);

            //Get description
            _description = ReadString("Enter optional description: ", false);

            //Get length in minutes
            _duration = ReadInteger("Enter length in minutes: ", 0);

            //Get owned status
            _owned = ReadBool("Do you own this movie? (Y/N): ");
        }

        private static string ReadString( string message, bool isRequired )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                //If required or not empty
                if (!isRequired || value != "")
                    return value;

                Console.WriteLine("Value is required");
            } while (true);
        }

        private static int ReadInteger( string message, int minValue )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                // if (Decimal.TryParse(value, out decimal result) && result >= minValue)
                // return result;

                if (Int32.TryParse(value, out int result))
                {
                    //If required or not empty
                    if (result >= minValue)
                        return result;
                };

                //Console.WriteLine("Value must be >= {0}", minValue); // This is a format string

                string msg = String.Format("Value must be >= {0}", minValue);
                Console.WriteLine(msg);

            } while (true);
        }

        private static bool ReadBool( string message )

        {
            while ( 0 == 0 )
            {
                Console.Write(message);

                string choice = Console.ReadLine();

                choice = choice.Trim();

                choice = choice.ToUpper();

                if (String.Compare(choice, "Y", true) == 0)
                    return true;
                if (String.Compare(choice, "N", true) == 0)
                    return false;

                Console.WriteLine("Please enter Y or N");
            }
        }

        private static void RemoveMovie()
        {

            bool choice = ReadBool($"Are you sure you want to delete {_title}? (Y/N)");

            if (choice == true)
            {
                _title = null;
                _description = null;
                _duration = 0;
                _owned = false;

                Console.WriteLine("Movie successfully deleted");
            } else Console.WriteLine($"{_title} was not deleted");
        }

        private static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("L)ist Movies");
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("R)emove Movie");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                
                input = input.Trim();
               
                input = input.ToUpper();
                
                if (String.Compare(input, "L", true) == 0)
                    return input[0];
                if (String.Compare(input, "A", true) == 0)
                    return input[0];
                if (String.Compare(input, "R", true) == 0)
                    return input[0];
                if (String.Compare(input, "Q", true) == 0)
                    return input[0];

                Console.WriteLine("Please choose a valid option");
            } while (true);

        }

        static void ListMovies()
        {
            //Are there any movies?            
            if (!String.IsNullOrEmpty(_title))
            {

                Console.WriteLine(_title);

                Console.WriteLine($"{_duration} minutes");

                if (!String.IsNullOrEmpty(_description))
                    Console.WriteLine(_description);

                if (_owned == true)
                    Console.WriteLine("Owned");
                else if (_owned == false)
                    Console.WriteLine("Not Owned");

            } else
                Console.WriteLine("No Movies");
        }
        //Data for a movie
        static string _title;
        static string _description;
        static int _duration;
        static bool _owned;
    }
}

    
    

