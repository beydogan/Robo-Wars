using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int creditA = 6000, creditB = 0;
            int ar1ThrowEn = 0, ar2ThrowEn = 0, ar3ThrowEn = 0, br1ThrowEn = 0, br2ThrowEn = 0, br3ThrowEn = 0;
            double ar1ThrowCap = 0, ar2ThrowCap = 0, ar3ThrowCap = 0, br1ThrowCap = 0, br2ThrowCap = 0, br3ThrowCap = 0;
            int ar1ProtEn = 0, ar2ProtEn = 0, ar3ProtEn = 0, br1ProtEn = 0, br2ProtEn = 0, br3ProtEn = 0;
            double ar1ProtCap = 0, ar2ProtCap = 0, ar3ProtCap = 0, br1ProtCap = 0, br2ProtCap = 0, br3ProtCap = 0;
            int ar1Target = 0, ar2Target = 0, ar3Target = 0;
            int br1Target, br2Target, br3Target;
            int throwEnergy, protEnergy;
            int ar1No= 0, ar2No = 0, ar3No = 0, br1No = 0, br2No = 0, br3No = 0;
            int ar1Price = 0, ar2Price = 0, ar3Price = 0;
            int br1Price = 0, br2Price = 0, br3Price = 0;
            int roundCounter = 1;
            int lowerLimit = 0;
            int ar1Status = 1, ar2Status = 1, ar3Status = 1;
            int spentCredit = 0;
            int teamATotal = 0, teamBTotal = 0;
            int highestThrowEn= 0, highestProtEn = 0;
            int key;

            Console.Title = "Robo-Wars"; // window title
            Console.WindowWidth = 94; // window width, to fit the table
            
          
            do
            {
                // Operations at the beginning of a new round
                if (roundCounter != 1)
                {
                    ar1ThrowEn = 0;
                    ar2ThrowEn = 0;
                    ar3ThrowEn = 0;
                    br1ThrowEn = 0;
                    br2ThrowEn = 0;
                    br3ThrowEn = 0;
                    ar1ProtEn = 0;
                    ar2ProtEn = 0;
                    ar3ProtEn = 0;
                    br1ProtEn = 0;
                    br2ProtEn = 0;
                    br3ProtEn = 0;
                    creditA = creditA + 4000;
                }

                Console.WriteLine("=== Game Round {0} ====", roundCounter);
                Console.WriteLine(" Stage 1: Credits of Teams");
                Console.WriteLine("A: " + creditA);
                if (roundCounter != 1)
                {
                    Console.WriteLine("B: " + creditB);
                }
                Console.WriteLine(" Stage 2: Choose robots");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("   +---Type No---+----Robot Type----+--Throw Capacity--+--Protection Capacity--+--Price--+   ");
                Console.WriteLine("   +      1      |        C64       |        400       |         350           |    600  +   ");
                Console.WriteLine("   +      2      |        C++       |        450       |         500           |    800  +   ");
                Console.WriteLine("   +      3      |      ZX Manga    |        600       |         550           |   1000  +   ");
                Console.WriteLine("   +      4      |        XR21      |        700       |         700           |   1300  +   ");
                Console.WriteLine("   +      5      |  Great Protector |        600       |         800           |   1700  +   ");
                Console.WriteLine("   +      6      |   Great Thrower  |        800       |         600           |   1900  +   ");
                Console.WriteLine("   +-------------+------------------+------------------+-----------------------+---------+   ");
                Console.ResetColor();
                Console.WriteLine("Note 1: Robot type 5 increases the protection capacity of the other robots in its team by %50");
                Console.WriteLine("Note 2: Robot type 6 increases the throw capacity of the other robots in its team by %50");

                //Team A's Robots
                if (ar1No == 0)
                {
                    do
                    {
                        Console.Write("Robot 1: ");
                        ar1No = Convert.ToInt32(Console.ReadLine());
                        if (ar1No < 1 || ar1No > 6)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please select between 1 and 6.");
                            Console.ResetColor();
                        }
                    } while (ar1No < 1 || ar1No > 6);
                    
                }
                if (ar2No == 0)
                {
                    do
                    {
                        Console.Write("Robot 2: ");
                        ar2No = Convert.ToInt32(Console.ReadLine());
                        if (ar2No < 1 || ar2No > 6)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please select between 1 and 6.");
                            Console.ResetColor();
                        }
                    } while (ar2No < 1 || ar2No > 6);
                }

                if (ar3No == 0)
                {
                    do
                    {
                        Console.Write("Robot 3: ");
                        ar3No = Convert.ToInt32(Console.ReadLine());
                        if (ar3No < 1 || ar3No > 6)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please select between 1 and 6.");
                            Console.ResetColor();
                        }
                    } while (ar3No < 1 || ar3No > 6);
                }
                // Team B's Robots
                if (br1No == 0)
                {
                    br1No = rnd.Next(1, 7);
                }
                if (br2No == 0)
                {
                    br2No = rnd.Next(1, 7);
                }
                if (br3No == 0)
                {
                    br3No = rnd.Next(1, 7);
                }

                // ============================= TEAM A'S PRICE AND CAPACITY OPERATIONS ================================= 
                // If Robot Type No: 1
                if (ar1No == 1)
                {
                    ar1Price = 600;
                    ar1ProtCap = 350;
                    ar1ThrowCap = 400;
                }
                if (ar2No == 1)
                {
                    ar2Price = 600;
                    ar2ProtCap = 350;
                    ar2ThrowCap = 400;
                }
                if (ar3No == 1)
                {
                    ar3Price = 600;
                    ar3ProtCap = 350;
                    ar3ThrowCap = 400;
                }

                // If Robot Type No: 2
                if (ar1No == 2)
                {
                    ar1Price = 800;
                    ar1ProtCap = 500;
                    ar1ThrowCap = 450;
                }
                if (ar2No == 2)
                {
                    ar2Price = 800;
                    ar2ProtCap = 500;
                    ar2ThrowCap = 450;
                }
                if (ar3No == 2)
                {
                    ar3Price = 800;
                    ar3ProtCap = 500;
                    ar3ThrowCap = 450;
                }
                // If Robot Type No: 3
                if (ar1No == 3)
                {
                    ar1Price = 1000;
                    ar1ProtCap = 550;
                    ar1ThrowCap = 600;
                }
                if (ar2No == 3)
                {
                    ar2Price = 1000;
                    ar2ProtCap = 550;
                    ar2ThrowCap = 600;
                }
                if (ar3No == 3)
                {
                    ar3Price = 1000;
                    ar3ProtCap = 550;
                    ar3ThrowCap = 600;
                }
                // If Robot Type No: 4
                if (ar1No == 4)
                {
                    ar1Price = 1300;
                    ar1ProtCap = 700;
                    ar1ThrowCap = 700;
                }
                if (ar2No == 4)
                {
                    ar2Price = 1300;
                    ar2ProtCap = 700;
                    ar2ThrowCap = 700;
                }
                if (ar3No == 4)
                {
                    ar3Price = 1300;
                    ar3ProtCap = 700;
                    ar3ThrowCap = 700;
                }
                // If Robot Type No: 5
                // Robot type 5 increases the protection capacity of the other robots in its team by %50
                if (ar1No == 5)
                {
                    ar1Price = 1700;
                    ar1ProtCap = 800;
                    ar1ThrowCap = 600;

                    ar2ProtCap = ar2ProtCap * 1.5;
                    ar3ProtCap = ar3ProtCap * 1.5;
                }
                if (ar2No == 5)
                {
                    ar2Price = 1700;
                    ar2ProtCap = 800;
                    ar2ThrowCap = 600;

                    ar1ProtCap = ar1ProtCap * 1.5;
                    ar3ProtCap = ar3ProtCap * 1.5;
                }
                if (ar3No == 5)
                {
                    ar3Price = 1700;
                    ar3ProtCap = 800;
                    ar3ThrowCap = 600;

                    ar1ProtCap = ar1ProtCap * 1.5;
                    ar2ProtCap = ar2ProtCap * 1.5;

                }
                // If Robot Type No: 6
                // Robot type 6 increases the throw capacity of the other robots in its team by %50
                if (ar1No == 6)
                {
                    ar1Price = 1900;
                    ar1ProtCap = 600;
                    ar1ThrowCap = 800;

                    ar2ThrowCap = ar2ThrowCap * 1.5;
                    ar3ThrowCap = ar3ThrowCap * 1.5;
                }
                if (ar2No == 6)
                {
                    ar2Price = 1900;
                    ar2ProtCap = 600;
                    ar2ThrowCap = 800;

                    ar1ThrowCap = ar1ThrowCap * 1.5;
                    ar3ThrowCap = ar3ThrowCap * 1.5;
                }
                if (ar3No == 6)
                {
                    ar3Price = 1900;
                    ar3ProtCap = 600;
                    ar3ThrowCap = 800;

                    ar1ThrowCap = ar1ThrowCap * 1.5;
                    ar2ThrowCap = ar2ThrowCap * 1.5;

                }
                // ============================= END OF TEAM A'S PRICE AND CAPACITY OPERATIONS =================================  

                // ============================= TEAM B'S PRICE AND CAPACITY OPERATIONS ================================= 
                // If Robot Type No: 1
                if (br1No == 1)
                {
                    br1Price = 600;
                    br1ProtCap = 350;
                    br1ThrowCap = 400;
                }
                if (br2No == 1)
                {
                    br2Price = 600;
                    br2ProtCap = 350;
                    br2ThrowCap = 400;
                }
                if (br3No == 1)
                {
                    br3Price = 600;
                    br3ProtCap = 350;
                    br3ThrowCap = 400;
                }

                // If Robot Type No: 2
                if (br1No == 2)
                {
                    br1Price = 800;
                    br1ProtCap = 500;
                    br1ThrowCap = 450;
                }
                if (br2No == 2)
                {
                    br2Price = 800;
                    br2ProtCap = 500;
                    br2ThrowCap = 450;
                }
                if (br3No == 2)
                {
                    br3Price = 800;
                    br3ProtCap = 500;
                    br3ThrowCap = 450;
                }
                // If Robot Type No: 3
                if (br1No == 3)
                {
                    br1Price = 1000;
                    br1ProtCap = 550;
                    br1ThrowCap = 600;
                }
                if (br2No == 3)
                {
                    br2Price = 1000;
                    br2ProtCap = 550;
                    br2ThrowCap = 600;
                }
                if (br3No == 3)
                {
                    br3Price = 1000;
                    br3ProtCap = 550;
                    br3ThrowCap = 600;
                }
                // If Robot Type No: 4
                if (br1No == 4)
                {
                    br1Price = 1300;
                    br1ProtCap = 700;
                    br1ThrowCap = 700;
                }
                if (br2No == 4)
                {
                    br2Price = 1300;
                    br2ProtCap = 700;
                    br2ThrowCap = 700;
                }
                if (br3No == 4)
                {
                    br3Price = 1300;
                    br3ProtCap = 700;
                    br3ThrowCap = 700;
                }
                // If Robot Type No: 5
                // Robot type 5 increases the protection capacity of the other robots in its team by %50
                if (br1No == 5)
                {
                    br1Price = 1700;
                    br1ProtCap = 800;
                    br1ThrowCap = 600;

                    br2ProtCap = br2ProtCap * 1.5;
                    br3ProtCap = br3ProtCap * 1.5;
                }
                if (br2No == 5)
                {
                    br2Price = 1700;
                    br2ProtCap = 800;
                    br2ThrowCap = 600;

                    br1ProtCap = br1ProtCap * 1.5;
                    br3ProtCap = br3ProtCap * 1.5;
                }
                if (br3No == 5)
                {
                    br3Price = 1700;
                    br3ProtCap = 800;
                    br3ThrowCap = 600;

                    br1ProtCap = br1ProtCap * 1.5;
                    br2ProtCap = br2ProtCap * 1.5;

                }
                // If Robot Type No: 6
                // Robot type 6 increases the throw capacity of the other robots in its team by %50
                if (br1No == 6)
                {
                    br1Price = 1900;
                    br1ProtCap = 600;
                    br1ThrowCap = 800;

                    br2ThrowCap = br2ThrowCap * 1.5;
                    br3ThrowCap = br3ThrowCap * 1.5;
                }
                if (br2No == 6)
                {
                    br2Price = 1900;
                    br2ProtCap = 600;
                    br2ThrowCap = 800;

                    br1ThrowCap = br1ThrowCap * 1.5;
                    br3ThrowCap = br3ThrowCap * 1.5;
                }
                if (br3No == 6)
                {
                    br3Price = 1900;
                    br3ProtCap = 600;
                    br3ThrowCap = 800;

                    br1ThrowCap = br1ThrowCap * 1.5;
                    br2ThrowCap = br2ThrowCap * 1.5;

                }
                // ============================= END OF TEAM B'S PRICE AND CAPACITY OPERATIONS =================================  

                // Remaning credit of Team A
                if (roundCounter != 1)
                {
                    if (ar1Status == 0)
                    {
                        spentCredit = spentCredit + ar1Price;
                    }
                    if (ar2Status == 0)
                    {
                        spentCredit = spentCredit + ar2Price;
                    }
                    if (ar3Status == 0)
                    {
                        spentCredit = spentCredit + ar3Price;
                    }

                }
                if (roundCounter == 1)
                {
                    if (ar1Status == 1)
                    {
                        spentCredit = spentCredit + ar1Price;
                    }
                    if (ar2Status == 1)
                    {
                        spentCredit = spentCredit + ar2Price;
                    }
                    if (ar3Status == 1)
                    {
                        spentCredit = spentCredit + ar3Price;
                    }

                }
                
                creditA = creditA - spentCredit;
                spentCredit = 0;
                Console.WriteLine(" Stage 3: Buy Energy");
                Console.Write("Remaning Credits: ");
                Console.WriteLine(creditA);

                do
                {
                    Console.Write("Throw Energy: ");
                    throwEnergy = Convert.ToInt32(Console.ReadLine());
                    if (throwEnergy > creditA)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Error! You can't buy energy more than " + creditA);
                        Console.ResetColor();
                    }
                }
                while (throwEnergy > creditA);
                creditA = creditA - throwEnergy;


                do
                {
                    Console.Write("Protection Energy: ");
                    protEnergy = Convert.ToInt32(Console.ReadLine());

                    if (protEnergy > creditA)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Error! You can't buy energy more than " + creditA);
                        Console.ResetColor();
                    }
                }
                while (protEnergy > creditA);
                creditA = creditA - protEnergy;



                // ============================ TEAM A'S ENERGY OPERATIONS ======================================
                Console.WriteLine(" Stage 4: Share Energy");
                // Throw Energy Operations
                do                                                  // Check sum of throw energies
                {
                    do
                    {
                        Console.Write("Robot 1 Throw Energy: ");
                        ar1ThrowEn = Convert.ToInt32(Console.ReadLine());
                        if (ar1ThrowEn > ar1ThrowCap)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! You can't enter more than robot's capacity. Robot capacity is " + ar1ThrowCap);
                            Console.ResetColor();
                        }
                        if (ar1ThrowEn < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please enter a number bigger than 0");
                            Console.ResetColor();
                        }
                    } while (ar1ThrowEn > ar1ThrowCap || ar1ThrowEn < 0);

                    do
                    {
                        Console.Write("Robot 2 Throw Energy: ");
                        ar2ThrowEn = Convert.ToInt32(Console.ReadLine());
                        if (ar2ThrowEn > ar2ThrowCap)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! You can't enter more than robot's capacity. Robot capacity is " + ar2ThrowCap);
                            Console.ResetColor();
                        }
                        if (ar2ThrowEn < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please enter a number bigger than 0");
                            Console.ResetColor();
                        }
                    } while (ar2ThrowEn > ar2ThrowCap || ar2ThrowEn < 0);

                    do
                    {
                        Console.Write("Robot 3 Throw Energy: ");
                        ar3ThrowEn = Convert.ToInt32(Console.ReadLine());
                        if (ar3ThrowEn > ar3ThrowCap)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! You can't enter more than robot's capacity. Robot capacity is " + ar3ThrowCap);
                            Console.ResetColor();
                        }
                        if (ar3ThrowEn < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please enter a number bigger than 0");
                            Console.ResetColor();
                        }
                    } while (ar3ThrowEn > ar3ThrowCap || ar3ThrowEn < 0);

                    if (ar1ThrowEn + ar2ThrowEn + ar3ThrowEn > throwEnergy)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Error! You have " + throwEnergy + " throw energy. You can't share more than it");
                        Console.ResetColor();
                    }
                } while (ar1ThrowEn + ar2ThrowEn + ar3ThrowEn > throwEnergy);

                // Protection Energy Operations
                do                                                      // Check sum of protection energies
                {
                    do
                    {
                        Console.Write("Robot 1 Protection Energy: ");
                        ar1ProtEn = Convert.ToInt32(Console.ReadLine());
                        if (ar1ProtEn > ar1ProtCap)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! You can't enter more than robot's capacity. Robot capacity is " + ar1ProtCap);
                            Console.ResetColor();
                        }
                        if (ar1ProtEn < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please enter a number bigger than 0");
                            Console.ResetColor();
                        }
                    } while (ar1ProtEn > ar1ProtCap || ar1ProtEn < 0);

                    do
                    {
                        Console.Write("Robot 2 Protection Energy: ");
                        ar2ProtEn = Convert.ToInt32(Console.ReadLine());
                        if (ar2ProtEn > ar2ProtCap)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! You can't enter more than robot's capacity. Robot capacity is " + ar2ProtCap);
                            Console.ResetColor();
                        }
                        if (ar2ProtEn < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please enter a number bigger than 0");
                            Console.ResetColor();
                        }
                    } while (ar2ProtEn > ar2ProtCap || ar2ProtEn < 0);

                    do
                    {
                        Console.Write("Robot 3 Protection Energy: ");
                        ar3ProtEn = Convert.ToInt32(Console.ReadLine());
                        if (ar3ProtEn > ar3ProtCap)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! You can't enter more than robot's capacity. Robot capacity is " + ar3ProtCap);
                            Console.ResetColor();
                        }
                        if (ar3ProtEn < 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Error! Please enter a number bigger than 0");
                            Console.ResetColor();
                        }
                    } while (ar3ProtEn > ar3ProtCap || ar3ProtEn < 0);

                    if (ar1ProtEn + ar2ProtEn + ar3ProtEn > protEnergy)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Error! You have " + protEnergy + " protection energy. You can't share more than it");
                        Console.ResetColor();
                    }
                } while (ar1ProtEn + ar2ProtEn + ar3ProtEn > protEnergy);


                // ============================ END OF TEAM A'S ENERGY OPERATIONS ======================================

                // =============================== TEAM B'S ENERGY OPERATIONS ==========================================
                if (roundCounter == 1)
                {
                    lowerLimit = 250;
                }
                if (roundCounter == 2)
                {
                    lowerLimit = 300;
                }
                if (roundCounter == 3)
                {
                    lowerLimit = 350;
                }

                br1ThrowEn = rnd.Next(lowerLimit, Convert.ToInt32(br1ThrowCap) + 1);
                br2ThrowEn = rnd.Next(lowerLimit, Convert.ToInt32(br2ThrowCap) + 1);
                br3ThrowEn = rnd.Next(lowerLimit, Convert.ToInt32(br3ThrowCap) + 1);
                
                br1ProtEn = rnd.Next(lowerLimit, Convert.ToInt32(br1ProtCap) + 1);
                br2ProtEn = rnd.Next(lowerLimit, Convert.ToInt32(br2ProtCap) + 1);
                br3ProtEn = rnd.Next(lowerLimit, Convert.ToInt32(br3ProtCap) + 1);

                // =============================== END OF TEAM B'S ENERGY OPERATIONS ===================================

                Console.WriteLine(" Stage 5: Choose Strategy\n ");

                Console.WriteLine("                               == Team A's Stats ==");
                Console.WriteLine("   +----Robot----+--Robot Type No--+--Throw Energy--+--Protection Energy--+");
                Console.WriteLine("   +      1      |        " + ar1No + "        |        " + ar1ThrowEn + "     |         " + ar1ProtEn + "         +");
                Console.WriteLine("   +      2      |        " + ar2No + "        |        " + ar2ThrowEn + "     |         " + ar2ProtEn + "         +");
                Console.WriteLine("   +      3      |        " + ar3No + "        |        " + ar3ThrowEn + "     |         " + ar3ProtEn + "         +");
                Console.WriteLine("   +----------------------------------------------------------------------+");
                Console.WriteLine("===============================================================================================");
                Console.WriteLine("                               == Team B's Stats ==");
                Console.WriteLine("   +----Robot----+--Robot Type No--+--Throw Energy--+--Protection Energy--+");
                Console.WriteLine("   +      1      |        " + br1No + "        |        " + br1ThrowEn + "     |         " + br1ProtEn + "         +");
                Console.WriteLine("   +      2      |        " + br2No + "        |        " + br2ThrowEn + "     |         " + br2ProtEn + "         +");
                Console.WriteLine("   +      3      |        " + br3No + "        |        " + br3ThrowEn + "     |         " + br3ProtEn + "         +");
                Console.WriteLine("   +----------------------------------------------------------------------+");

                Console.WriteLine("==== Team A's Targets ====");
                do
                {
                    Console.Write("Robot 1's Target: ");
                    ar1Target = Convert.ToInt32(Console.ReadLine());
                    if (ar1Target < 1 || ar1Target > 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Error! Please enter 1, 2 or 3");
                        Console.ResetColor();
                    }
                } while (ar1Target < 1 || ar1Target > 3);

                do
                {
                    Console.Write("Robot 2's Target: ");
                    ar2Target = Convert.ToInt32(Console.ReadLine());
                    if (ar1Target < 1 || ar1Target > 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Error! Please enter 1, 2 or 3");
                        Console.ResetColor();
                    }

                } while (ar2Target < 1 || ar2Target > 3);

                do
                {
                    Console.Write("Robot 3's Target: ");
                    ar3Target = Convert.ToInt32(Console.ReadLine());
                    if (ar3Target < 1 || ar3Target > 3)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Error! Please enter 1, 2 or 3");
                        Console.ResetColor();
                    }

                } while (ar3Target < 1 || ar3Target > 3);


                Console.WriteLine("==== Team B's Targets ====");
                // Team B chooses its targets randomly (1, 2 or 3) 
                br1Target = rnd.Next(1, 4);
                br2Target = rnd.Next(1, 4);
                br3Target = rnd.Next(1, 4);

                Console.WriteLine("Robot 1's Target: " + br1Target);
                Console.WriteLine("Robot 2's Target: " + br2Target);
                Console.WriteLine("Robot 3's Target: " + br3Target);

                Console.WriteLine("                   ======Targets of Teams======");
                Console.WriteLine("                +--Robot--+--TEAM A--+--TEAM B--+");
                Console.WriteLine("                +    1    |     " + ar1Target + "    |     " + br1Target + "    +");
                Console.WriteLine("                +    2    |     " + ar2Target + "    |     " + br2Target + "    +");
                Console.WriteLine("                +    3    |     " + ar3Target + "    |     " + br3Target + "    +");
                Console.WriteLine("                +---------+----------+----------+");

                // Stage 6

                // Identical types
                string identicalTypes = "Identical Types: ";
                if (ar1No == br1No || ar1No == br2No || ar1No == br3No)
                {
                    identicalTypes = identicalTypes + Convert.ToString(ar1No) + " ";
                }

                if ((ar2No == br1No || ar2No == br2No || ar2No == br3No) & (ar1No != ar2No))
                {
                    identicalTypes = identicalTypes + Convert.ToString(ar2No) + " ";
                }

                if ((ar3No == br1No || ar3No == br2No || ar3No == br3No) & ((ar1No != ar2No) & (ar3No != ar2No)))
                {
                    identicalTypes = identicalTypes + Convert.ToString(ar3No) + " ";
                }

                // --- End of identical types ---

                // Different Types

                string diffTypes = "Different Types: " + ar1No;

                if (ar1No != ar2No)
                {
                    diffTypes = diffTypes + " " + ar2No;
                }

                if (ar3No != ar2No && ar1No != ar3No)
                {
                    diffTypes = diffTypes + " " + ar3No;
                }

                if (br1No != ar1No & br1No != ar2No & br1No != ar3No)
                {
                    diffTypes = diffTypes + " " + br1No;
                }

                if (br2No != ar1No & br2No != ar2No & br2No != ar3No & br2No != br1No)
                {
                    diffTypes = diffTypes + " " + br2No;
                }

                if (br3No != ar1No & br3No != ar2No & br3No != ar3No & br3No != br1No & br3No != br2No)
                {
                    diffTypes = diffTypes + " " + br3No;
                }
                // --- End of different types ---

                // highest energy operations

                // -- highest throw energy --
                highestThrowEn = (Math.Max(ar1ThrowEn, Math.Max(ar2ThrowEn, Math.Max(ar3ThrowEn, Math.Max(br1ThrowEn, Math.Max(br2ThrowEn, br3ThrowEn))))));
                string highestThrowEnString = "Highest Throw Energy: ";
                if (ar1ThrowEn == highestThrowEn)
                {
                    highestThrowEnString = highestThrowEnString + "Team A's robot " + ar1No + " ";
                }
                if (ar2ThrowEn == highestThrowEn)
                {
                    highestThrowEnString = highestThrowEnString + "Team A's robot " + ar2No + " ";
                }
                if (ar3ThrowEn == highestThrowEn)
                {
                    highestThrowEnString = highestThrowEnString + "Team A's robot " + ar3No + " ";
                }

                if (br1ThrowEn == highestThrowEn)
                {
                    highestThrowEnString = highestThrowEnString + "Team B's robot " + br1No + " ";
                }
                if (br2ThrowEn == highestThrowEn)
                {
                    highestThrowEnString = highestThrowEnString + "Team B's robot " + br2No + " ";
                }
                if (br3ThrowEn == highestThrowEn)
                {
                    highestThrowEnString = highestThrowEnString + "Team B's robot " + br3No + " ";
                }
                // -- end of highest throw energy --

                // -- highest protection energy --

                highestProtEn = (Math.Max(ar1ProtEn, Math.Max(ar2ProtEn, Math.Max(ar3ProtEn, Math.Max(br1ThrowEn, Math.Max(br2ProtEn, br3ProtEn))))));
                string highestProtEnString = "Highest Protection Energy: ";
                if (ar1ProtEn == highestProtEn)
                {
                    highestProtEnString = highestProtEnString + "Team A's robot " + ar1No + " ";
                }
                if (ar2ProtEn == highestProtEn)
                {
                    highestProtEnString = highestProtEnString + "Team A's robot " + ar2No + " ";
                }
                if (ar3ProtEn == highestProtEn)
                {
                    highestProtEnString = highestProtEnString + "Team A's robot " + ar3No + " ";
                }

                if (br1ProtEn == highestProtEn)
                {
                    highestProtEnString = highestProtEnString + "Team B's robot " + br1No + " ";
                }
                if (br2ProtEn == highestProtEn)
                {
                    highestProtEnString = highestProtEnString + "Team B's robot " + br2No + " ";
                }
                if (br3ProtEn == highestProtEn)
                {
                    highestProtEnString = highestProtEnString + "Team B's robot " + br3No + " ";
                }

                // -- end of highest protection energy --

                // end of highest energy operations

                // ================================ TEAM A's Targets ===========================

                if (ar1Target == 1)
                {
                    br1ProtEn = br1ProtEn - ar1ThrowEn;
                }
                if (ar2Target == 1)
                {
                    br1ProtEn = br1ProtEn - ar2ThrowEn;
                }
                if (ar3Target == 1)
                {
                    br1ProtEn = br1ProtEn - ar3ThrowEn;
                }
                if (ar1Target == 2)
                {
                    br2ProtEn = br2ProtEn - ar1ThrowEn;
                }
                if (ar2Target == 2)
                {
                    br2ProtEn = br2ProtEn - ar2ThrowEn;
                }
                if (ar3Target == 2)
                {
                    br2ProtEn = br2ProtEn - ar3ThrowEn;
                }
                if (ar1Target == 3)
                {
                    br3ProtEn = br3ProtEn - ar1ThrowEn;
                }
                if (ar2Target == 3)
                {
                    br3ProtEn = br3ProtEn - ar2ThrowEn;
                }
                if (ar3Target == 3)
                {
                    br3ProtEn = br3ProtEn - ar3ThrowEn;
                }
                // ================================ END OF TEAM A's Targets ===========================


                // ================================ TEAM B's Targets ==================================

                if (br1Target == 1)
                {
                    ar1ProtEn = ar1ProtEn - br1ThrowEn;
                }
                if (br2Target == 1)
                {
                    ar1ProtEn = ar1ProtEn - br2ThrowEn;
                }
                if (br3Target == 1)
                {
                    ar1ProtEn = ar1ProtEn - br3ThrowEn;
                }
                if (br1Target == 2)
                {
                    ar2ProtEn = ar2ProtEn - br1ThrowEn;
                }
                if (br2Target == 2)
                {
                    ar2ProtEn = ar2ProtEn - br2ThrowEn;
                }
                if (br3Target == 2)
                {
                    ar2ProtEn = ar2ProtEn - br3ThrowEn;
                }
                if (br1Target == 3)
                {
                    ar3ProtEn = ar3ProtEn - br1ThrowEn;
                }
                if (br2Target == 3)
                {
                    ar3ProtEn = ar3ProtEn - br2ThrowEn;
                }
                if (br3Target == 3)
                {
                    ar3ProtEn = ar3ProtEn - br3ThrowEn;
                }
                // ================================ END OF TEAM B's Targets ===========================


                if (ar1ProtEn <= 0)
                {
                    ar1Status = 0;
                    ar1No = 0;
                    creditB = creditB + ar1Price;
                }
                else
                {
                    ar1Status = 1;
                }
                 
                if (ar2ProtEn <= 0)
                {
                    ar2Status = 0;
                    ar2No = 0;
                    creditB = creditB + ar2Price;
                }
                else
                {
                    ar2Status = 1;
                }

                if (ar3ProtEn <= 0)
                {
                    ar3Status = 0;
                    ar3No = 0;
                    creditB = creditB + ar3Price;
                }
                else
                {
                    ar3Status = 1;
                }

                if (br1ProtEn <= 0)
                {
                    br1No = 0;
                    creditA = creditA + br1Price;
                }
                if (br2ProtEn <= 0)
                {
                    br2No = 0;
                    creditA = creditA + br2Price;
                }
                if (br3ProtEn <= 0)
                {
                    br3No = 0;
                    creditA = creditA + br3Price;
                }
           
                // waiting animation

                Console.WriteLine("Battle in progress");
                for (int i = 0; i < 15; i++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(80);

                }

                Console.WriteLine("\n                               == Team A'==                           ");
                Console.WriteLine("Robot 1: " + ar1No);
                Console.WriteLine("Robot 2: " + ar2No);
                Console.WriteLine("Robot 3: " + ar3No);
                Console.WriteLine("0 means dead.");
                Console.WriteLine("============================================================================================");
                Console.WriteLine("                               == Team B'==                          ");
                Console.WriteLine("Robot 1: " + br1No);
                Console.WriteLine("Robot 2: " + br2No);
                Console.WriteLine("Robot 3: " + br3No);
                Console.WriteLine("0 means dead.");
                Console.WriteLine(diffTypes);
                Console.WriteLine(identicalTypes);
                Console.WriteLine(highestThrowEnString);
                Console.WriteLine(highestProtEnString);
                Console.WriteLine("Team A Credits: " + creditA);
                Console.WriteLine("Team B Credits: " + creditB);

                if (roundCounter == 3)
                {
                    teamATotal = creditA + ar1Price + ar2Price + ar3Price;
                    teamBTotal = creditB + br1Price + br2Price + br3Price;

                    if (teamATotal < teamBTotal)
                    {
                        Console.WriteLine("Team A wins the game with half victory");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                    }
                    if (teamBTotal > teamATotal)
                    {
                        Console.WriteLine("Team B wins the game with half victory");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                    }

                }
                if (ar1No != 0 || ar2No != 0 || ar3No != 0 || br1No != 0 || br2No != 0 || br3No != 0)
                {
                    roundCounter++;
                }

                if (ar1No == 0 && ar2No == 0 && ar3No == 0 && br1No == 0 && br2No == 0 && br3No == 0)
                {
                    Console.WriteLine("There is no winner!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    roundCounter = 4;
                }
               
                if (ar1No == 0 && ar2No == 0 && ar3No == 0)
                {
                    Console.WriteLine("Team B wins the game with full victory");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    roundCounter = 4;
                }

                if (br1No == 0 && br2No == 0 && br3No == 0)
                {
                    Console.WriteLine("Team A wins the game with full victory");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    roundCounter = 4;
                }
                
                if (roundCounter != 4)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("New Round Begining");
                    for (int j = 0; j < 15; j++)
                    {
                        Console.Write(".");
                        System.Threading.Thread.Sleep(80);

                    }
                    Console.Clear();

                }
             
            } while (roundCounter <= 3);


        }
    }
}
