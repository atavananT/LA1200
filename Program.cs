using System;

namespace RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Gib deinen Namen ein:\n");
            Console.ForegroundColor = ConsoleColor.Yellow; String eingabe = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hallo " + eingabe + ", willkommen zum Zahlenrätsel. Ich wünsche dir viel Glück und viel Spass :)");
            Console.WriteLine("-----------------------------------------------------------------------------------");


            Random zufall = new Random();
            int rate = 0;
            Console.ForegroundColor = ConsoleColor.White;
            string start = "\n\nErrate eine Zahl zwischen 1 und 100\n";
            int zahl = zufall.Next(1, 100);
            Console.WriteLine(start);
        

            
            int i = 0;
            {
                
                while (rate != zahl)
                {
                    try
                    {
                            Console.ForegroundColor = ConsoleColor.DarkCyan; rate = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;

                            if (rate > zahl)
                            {
                                Console.WriteLine("Die Zahl ist zu gross");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("---------------------\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (rate < zahl)
                            {
                                Console.WriteLine("Die Zahl ist zu klein");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("---------------------\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (rate == zahl)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n--------------------------------------------------------------------------");
                                Console.WriteLine("Herzlichen Glückwunsch " + eingabe + ", es war die Zahl " + zahl + " und du hattest " + i + " Versuche!");
                                Console.WriteLine("--------------------------------------------------------------------------");
                           


                            }
                    }

                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Fehlereingabe (Bitte eine Zahl eingeben)");
                        Console.ForegroundColor = ConsoleColor.White;
                        i--;
                    }

                    i++;

                }

            }

            Console.ReadLine();

        }
    }
}
