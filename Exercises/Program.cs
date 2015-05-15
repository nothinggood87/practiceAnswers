using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xa0 = 0; xa0 <= 1000; xa0++) 
            {


                Console.WriteLine("\nWhat Chapter?(1-1)");
                int xa1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What Exercise?(1-10)");
                int xa2 = Convert.ToInt32(Console.ReadLine());
                switch (xa1)
                {
                    case 1:
                        {
                            switch (xa2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Hello world my name is Andrew!");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine(@"  _____                    ");
                                        Console.WriteLine(@" /           |  |          ");
                                        Console.WriteLine(@"|        ____|__|____      ");
                                        Console.WriteLine(@"|        ____|__|____      ");
                                        Console.WriteLine(@"|            |  |          ");
                                        Console.WriteLine(@" \_____      |  |          ");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Name: Andrew");
                                        Console.WriteLine("School: Homeschool");
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                        Console.WriteLine("+      Program Assignment #4                       +");
                                        Console.WriteLine("+      Developer: Andrew                           +");
                                        Console.WriteLine("+      Date Submitted: May 13                      +");
                                        Console.WriteLine("+      Purpose: Provide internal documentation     +");
                                        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                        break;
                                    }
                                case 5:
                                    {
                                        Console.WriteLine(@"           OOOOOOOOOOOOOOOOOOOOOOOOOOO");//1
                                        Console.WriteLine(@"           OOOOOOOOOOOOOOOOOOOOOOOOOOO");//2
                                        Console.WriteLine(@"    /\     OOOOOOOOOOOOOOOOOOOOOOOOOOO");//3
                                        Console.WriteLine(@" __/  \__  OOOOOOOOOOOOOOOOOOOOOOOOOOO");//4
                                        Console.WriteLine(@" \      /  OOOOOOOOOOOOOOOOOOOOOOOOOOO");//5
                                        Console.WriteLine(@"  | /\ |   @@@@@@@@@@@@@@@@@@@@@@@@@@@");//6
                                        Console.WriteLine(@"  |/  \|   @@@@@@@@@@@@@@@@@@@@@@@@@@@");//7
                                        Console.WriteLine(@"           @@@@@@@@@@@@@@@@@@@@@@@@@@@");//8
                                        Console.WriteLine(@"           @@@@@@@@@@@@@@@@@@@@@@@@@@@");//9
                                        Console.WriteLine(@"           @@@@@@@@@@@@@@@@@@@@@@@@@@@");//0
                                        break;
                                    }
                                case 6:
                                    {
                                        Console.Write("Live well");
                                        Console.Write(" and prosper");
                                        Console.WriteLine();
                                        Console.WriteLine("Live well");
                                        Console.WriteLine("and prosper");
                                        Console.WriteLine();
                                        Console.WriteLine("live");
                                        Console.WriteLine("well");
                                        Console.WriteLine("and");
                                        Console.WriteLine("prosper");
                                        break;
                                    }
                                case 7:
                                    {
                                        Console.WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                        Console.WriteLine(@"+:      Name: Andrew\                              +");
                                        Console.WriteLine(@"+       Hometown:Amarillo\                         +");
                                        Console.WriteLine(@"+       Majer: Engineering\                        +");
                                        Console.WriteLine(@"+      Favorite Activity:Being Lazy\               +");
                                        Console.WriteLine(@"++++++++++++++++++++++++++++++++++++++++++++++++++++");
                                        break;

                                    }
                                case 8:
                                    {
                                        Console.WriteLine(@"(^;^)");
                                        Console.WriteLine(@"  |  ");
                                        Console.WriteLine(@"./|\.");
                                        Console.WriteLine(@"  |  ");
                                        Console.WriteLine(@"_/ \_");

                                        break;

                                    }
                                case 9:
                                    {
                                        Console.WriteLine(@"#######      M               ");
                                        Console.WriteLine(@"#######     MMM       /\    ");
                                        Console.WriteLine(@"#######    MMMMM     //\\  ");
                                        Console.WriteLine(@"#######   MMMMMMM    \\//  ");
                                        Console.WriteLine(@"#######  MMMMMMMMM    \/    ");

                                        break;

                                    }
                                case 10:
                                    {
                                        Console.WriteLine(@"\        /\        /      _______    | _______           |    _______    ");
                                        Console.WriteLine(@" \      /  \      /      /       \   |/           _______|   /           ");
                                        Console.WriteLine(@"  \    /    \    /      |         |  |           /       |   \_______    ");
                                        Console.WriteLine(@"   \  /      \  /       |         |  |          |        |           \   ");
                                        Console.WriteLine(@"    \/        \/         \_______/   |           \______/    \_______/   ");

                                        break;

                                    }
                                default: { Console.WriteLine("im sorry that does not exist \nplease try something else."); break; }
                            }

                            break;
                        }
                    default: { Console.WriteLine("im sorry that does not exist \nplease try something else."); break; }
                }
            }
            Console.ReadKey();
        }
    }
}
