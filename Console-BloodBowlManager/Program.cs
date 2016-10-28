using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_BloodBowlManager.Objects;

namespace Console_BloodBowlManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Positional HumanLineman = new Positional("Lineman", "Human", null, 50, 6, 3, 3, 8, new string[] { "General" }, new string[] { "Strength", "Agility", "Passing" });
            Player playerone = new Player("Karl Huntsmann", new Positional("Human", "Lineman"), 8);
            Player playertwo = new Player("Henri Bowler", new Positional("Human", "Thrower"), 7);
            Team team1 = new Team("Nordland Patriots", 1, new int[] { 100, 100, 110 });
            team1.Add(playerone);
            team1.Add(playertwo);



            //Console.ForegroundColor = ToCCSmart(team1.Color);
            /*foreach (var player in team1)
            {
                Console.WriteLine(player.ToString());
            }*/
            Console.WriteLine(playerone);
            //Console.Write("{0}{1}{2}", r, g, b);

            //Console.WriteLine();


            Console.ReadKey();
        }
        /*
        static ConsoleColor ToCCSmart(int[] rgb)
        {
            int[] color = new int []{rgb[0], rgb[1], rgb[2]};
            ConsoleColor[] colors = new ConsoleColor[]{ ConsoleColor.Black,
                                                        ConsoleColor.Blue,
                                                        ConsoleColor.Cyan,
                                                        ConsoleColor.DarkBlue,
                                                        ConsoleColor.DarkCyan,
                                                        ConsoleColor.DarkGray,
                                                        ConsoleColor.DarkGreen,
                                                        ConsoleColor.DarkMagenta,
                                                        ConsoleColor.DarkRed,
                                                        ConsoleColor.DarkYellow,
                                                        ConsoleColor.Gray,
                                                        ConsoleColor.Green,
                                                        ConsoleColor.Magenta,
                                                        ConsoleColor.Red,
                                                        ConsoleColor.White,
                                                        ConsoleColor.Yellow};
            
            double bestSqrDist = Int32.MaxValue;
            ConsoleColor bestColor = ConsoleColor.Black;
            foreach (ConsoleColor concolor in colors)
            {
                double sqrDist = Math.Sqrt(color[0] - RValue(concolor)) +
                                    Math.Sqrt(color[1] - GValue(concolor)) +
                                    Math.Sqrt(color[2] - BValue(concolor));
                if (sqrDist < bestSqrDist)
                {
                    bestSqrDist = sqrDist;
                    bestColor = concolor;
                }
            }
            return bestColor;
        }
        static int RValue(ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:
                    return 0;
                case ConsoleColor.Blue:
                    return 0;
                case ConsoleColor.Cyan:
                    return 0;
                case ConsoleColor.DarkBlue:
                    return 0;
                case ConsoleColor.DarkCyan:
                    return 0;
                case ConsoleColor.DarkGray:
                    return 128;
                case ConsoleColor.DarkGreen:
                    return 0;
                case ConsoleColor.DarkMagenta:
                    return 128;
                case ConsoleColor.DarkRed:
                    return 128;
                case ConsoleColor.DarkYellow:
                    return 128;
                case ConsoleColor.Gray:
                    return 192;
                case ConsoleColor.Green:
                    return 0;
                case ConsoleColor.Magenta:
                    return 255;
                case ConsoleColor.Red:
                    return 255;
                case ConsoleColor.White:
                    return 255;
                case ConsoleColor.Yellow:
                    return 255;
                default:
                    return 0;
            }
        }
        static int GValue (ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:
                    return 0;
                case ConsoleColor.Blue:
                    return 0;
                case ConsoleColor.Cyan:
                    return 255;
                case ConsoleColor.DarkBlue:
                    return 0;
                case ConsoleColor.DarkCyan:
                    return 128;
                case ConsoleColor.DarkGray:
                    return 128;
                case ConsoleColor.DarkGreen:
                    return 128;
                case ConsoleColor.DarkMagenta:
                    return 0;
                case ConsoleColor.DarkRed:
                    return 0;
                case ConsoleColor.DarkYellow:
                    return 128;
                case ConsoleColor.Gray:
                    return 192;
                case ConsoleColor.Green:
                    return 255;
                case ConsoleColor.Magenta:
                    return 0;
                case ConsoleColor.Red:
                    return 0;
                case ConsoleColor.White:
                    return 255;
                case ConsoleColor.Yellow:
                    return 255;
                default:
                    return 0;
            }
        }
        static int BValue (ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:
                    return 0;
                case ConsoleColor.Blue:
                    return 255;
                case ConsoleColor.Cyan:
                    return 255;
                case ConsoleColor.DarkBlue:
                    return 128;
                case ConsoleColor.DarkCyan:
                    return 128;
                case ConsoleColor.DarkGray:
                    return 128;
                case ConsoleColor.DarkGreen:
                    return 0;
                case ConsoleColor.DarkMagenta:
                    return 128;
                case ConsoleColor.DarkRed:
                    return 0;
                case ConsoleColor.DarkYellow:
                    return 0;
                case ConsoleColor.Gray:
                    return 192;
                case ConsoleColor.Green:
                    return 0;
                case ConsoleColor.Magenta:
                    return 255;
                case ConsoleColor.Red:
                    return 0;
                case ConsoleColor.White:
                    return 255;
                case ConsoleColor.Yellow:
                    return 0;
                default:
                    return 0;
            }
        }
        static ConsoleColor ToCC(int[] rgb)
        {
            int[] svar = new int[3];
            for (int i = 0; i < 3; i++ )
            {
                if (rgb[i] >= 223)
                {
                    svar[i] = 255; 
                }
                else if (rgb[i] >= 160)
                {
                    svar[i] = 192;
                }
                else if (rgb[i] >= 64)
                {
                    svar[i] = 128;
                }
                else
                {
                    svar[i] = 0;
                }
            }
            switch (svar[0])
            {
                case 255:
                    switch (svar[1])
                    {
                        case 255:
                            switch (svar[2])
                            {
                                case 255:
                                    return ConsoleColor.White;
                                case 0:
                                    return ConsoleColor.Yellow;
                                default:
                                    break;
                            }
                            break;
                        case 0:
                            switch (svar[2])
                            {
                                case 0:
                                    return ConsoleColor.Red;
                                case 255:
                                    return ConsoleColor.Magenta;
                                default:
                                    break;
                            }
                            break;
                            
                        default:
                            break;
                    }
                    break;
                case 192:
                    switch (svar[1])
                    {
                        case 192:
                            switch (svar[2])
                            {
                                case 192:
                                    return ConsoleColor.Gray;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 128:
                    switch (svar[1])
                    {
                        case 128:
                            switch (svar[2])
                            {
                                case 0:
                                    return ConsoleColor.DarkYellow;
                                case 128:
                                    return ConsoleColor.DarkGray;
                                default:
                                    break;
                            }
                            break;
                        case 0:
                            switch (svar[2])
                            {
                                case 0:
                                    return ConsoleColor.DarkRed;
                                case 128:
                                    return ConsoleColor.DarkMagenta;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 0:
                    switch (svar[1])
                    {
                        case 255:
                            switch (svar[2])
                            {
                                case 0:
                                    return ConsoleColor.Green;
                                case 255:
                                    return ConsoleColor.Cyan;
                                default:
                                    break;
                            }
                            break;
                        case 128:
                            switch (svar[2])
                            {
                                case 0:
                                    return ConsoleColor.DarkGreen;
                                case 128:
                                    return ConsoleColor.DarkCyan;
                                default:
                                    break;
                            }
                            break;
                        case 0:
                            switch (svar[2])
                            {
                                case 255:
                                    return ConsoleColor.Blue;
                                case  128:
                                    return ConsoleColor.DarkBlue;
                                case 0:
                                    return ConsoleColor.Black;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (svar[0] >= svar [1] && svar [0] >= svar[2])
            {
                return ConsoleColor.Red;
            }
            if (svar[1] >= svar [0] && svar [1] >= svar[2])
            {
                return ConsoleColor.Green;
            }
            if (svar [2] >= svar[0] && svar[2] >= svar[1])
            {
                return ConsoleColor.Blue;
            }
            return ConsoleColor.DarkGray;
        }
    }*/
    }
}
