// A Hello World! program in C#.
using System;

namespace HelloWorld
{
    class Hello
    {
        public static string searchterm;
        static void Main()
        {
            
            SearchPropmt();
            Console.WriteLine(searchterm);

                
        }

        private static void SearchPropmt()
        {   string check;
            bool test = false;

            while (!test) {


                Console.WriteLine("Please enter the school name to search.");

                searchterm = Console.ReadLine();

                Console.WriteLine("Just to check, you entered " + searchterm + " to look up. Are you sure? (Y/N)");

                check = Console.ReadLine();
                if (check == "y") {
                    test = true;
                }
                else {
                    test = false;
                }
            }
        }
    }
}
