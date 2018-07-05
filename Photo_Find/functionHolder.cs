using System;
namespace functionHolder
{
    public class Functions
    {
        public static string ST; //Search term asked in terminal
        public static int resultsnum; //Number of matches found (maxium of three results displayed currently)
        public static string result1; //The first result found if a result is found
        public static string result2;
        public static string result3;
        // <summary>
        // A function to ask what the user would like to search.
        // </summary>
        public static void SearchPropmt() //User end beinging prompts
        {
            string check; // Variable to see if the user wants to start search process
            bool readySearch = false;
            int i = 0; // loading while loop variable 

            while (!readySearch)
            {


                Console.WriteLine("Please enter the school name to search, then press enter."); // Begining Instruction

                ST = Console.ReadLine(); //set search term

                Console.WriteLine("Just to check, you entered " + ST + " to look up. Are you sure? (Y/N)"); //instructions to make sure user input is desired

                check = Console.ReadLine(); //set check value
                if (check == "y" || check == "Y") //if user inputed a y to signify yes
                {
                    readySearch = true;
                    while (i < 3)
                    {
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Loading...");
                        i++;
                    }
                }
                else
                { //if not restart process
                    readySearch = false;
                }
            }
        }
        public static void JSONParser2 (string input) {
            if (input == null)
            {
                Console.WriteLine("Error while searching, hmm. ERR_JSON_NULL");
            } else {
                string findImageBy = ST + " stock photo";
                if (input.IndexOf(findImageBy) != -1) {
                  /*int i = 0;
                    while ((i = input.IndexOf(findImageBy, i)) != -1)
                    {
                        // Print out the substring.
                        Console.WriteLine(input.Substring(i));

                        // Increment the index.
                        i++;
                    }
                } else {
                    resultsnum = 0;
                } */

            }
        }
    }
}
