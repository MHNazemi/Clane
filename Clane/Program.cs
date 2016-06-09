using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clane
{
    class Program
    {
        private SQLiteConnection sqlCon;
        static void Main(string[] args)
        {

            //SQLiteConnection con = new SQLiteConnection("Data Source=Clane.sqlite;Version=3;");
            //SQLiteCommand scom = new SQLiteCommand("create table News (Href nvarchar(200),Page int,Title nvarchar(500),Date datetime,Classified bit)", con);
            //con.Open();
            //scom.ExecuteNonQuery();
            //con.Close();

            Console.WriteLine("Welcome!\nFor fetching news enter 'f', \nfor continue classification enter 'c' \nand for exit enter 'e'\n:");
            string input = "";
            var mainLoop = true;
            while (mainLoop)
            {
                input = "";
                try
                {
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "f":
                        case "F":
                            break;
                        case "c":
                        case "C":
                            break;
                        case "e":
                        case "E":
                            mainLoop = false;
                            break;
                        default:
                            Console.WriteLine("\nYour input was incorrect! \nFor fetching news enter 'f', \nfor continue classification enter 'c' \nand for exit enter 'e'\n:");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("\nYour input was incorrect! \nFor fetching news enter 'f', \nfor continue classification enter 'c' \nand for exit enter 'e'\n:");
                }
            }
            Console.ReadLine();

        }
    }


    static class Crawler
    {
        public static void test()
        {

        }
    }
    static class Classifier
    {

    }

}
