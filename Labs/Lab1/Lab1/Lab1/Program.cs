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
                    ListMovies();
                    break;
                    case 'A':
                    AddMovie();
                    break;
                    case 'R':
                    RemoveMovie
                    case 'Q':
                    quit = true;
                    break;
                }
            };
        }
    }
    static void AddProduct()
    {
        //Get name
        _name = ReadString("Enter name: ", true);

        //Get name
        _price = ReadDecimal("Enter price: ", 0);

        //Get description
        _description = ReadString("Enter optional description: ", false);
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

    private static decimal ReadDecimal( string message, decimal minValue )
    {
        do
        {
            Console.Write(message);

            string value = Console.ReadLine();

            // if (Decimal.TryParse(value, out decimal result) && result >= minValue)
            // return result;

            if (Decimal.TryParse(value, out decimal result))
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

    private static char DisplayMenu()
    {
        do
        {
            Console.WriteLine("L)ist Products");
            Console.WriteLine("A)dd Product");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();

            //Remove whitespace
            input = input.Trim();
            //input.ToLower();
            input = input.ToUpper();

            //Padding
            //input = input.PadLeft(10);

            //Starts with
            //input.StartsWith(@"\");
            //Ends with
            //input.EndsWith(@"\");

            //if (input == "L")
            if (String.Compare(input, "L", true) == 0)
                return input[0];
            //else if (input == "A")
            if (String.Compare(input, "A", true) == 0)
                return input[0];
            // else if (input == "Q")
            if (String.Compare(input, "Q", true) == 0)
                return input[0];

            Console.WriteLine("Please choose a valid option");
        } while (true);

    }

    static void ListProducts()
    {
        //Are there any products?
        //if (_name != null && _name != "")
        if (!String.IsNullOrEmpty(_name))
        {//Display a product - name [$price]
         //<description>

            //String Concatentation
            //var msg = _name + " - [$" + _price + "]";

            //String concat pt 2
            //var msg = String.Concat(_name, " - [$", _price, "]");

            //String interpolation
            string msg = $"{_name} - [${_price}]";

            //String Formatting
            //var msg = String.Format("{0} - [${1}]", _name, _price);
            //Console.WriteLine(msg);

            //Console.WriteLine(_name);
            //Console.WriteLine(_price);

            if (!String.IsNullOrEmpty(_description))
                Console.WriteLine(_description);

        } else
            Console.WriteLine("No Products");
    }
    //Data for a product
    static string _name;
    static decimal _price;
    static string _description;
}
