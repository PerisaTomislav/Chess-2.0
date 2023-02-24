using Chess_Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chess_2._0.Options.NewGame.GameModes
{
    internal static class PvP
    {
        internal static void StartPvpGame()
        {

            
            Console.Clear();
            Board board = new Board();
            int turnCounter = 0;
            string playerMove = "";
            while (board.CheckGameStatus())
            {
                //White on move
                if (turnCounter % 2 == 0)
                {
                    do
                    {

                        //Izračunavanje mogućih poteza
                        Metode.OčistiPotezeFigura();
                        Metode.IzračunajMogućePoteze(Strana.Bijeli);
                        Metode.IzračunajMogućePoteze(Strana.Crni);
                        Metode.ProvjeriŠah(Strana.Bijeli);
                        Metode.ProvjeriJelNeriješeno(Strana.Bijeli);
                        if (Ploča.statusIgre == false || Ploča.neriješeno == true) break;
                        //Ispis ploče
                        Console.Clear();
                        Metode.IspišiPločuPvP(brojac);
                        Console.WriteLine();
                        if (Ploča.jeŠah == true && Ploča.stranaUŠahu == Strana.Bijeli)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Šah!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        Console.Write("Bijeli igra: ");
                        //Unos poteza
                        potezIgrača = Console.ReadLine();
                        //Provjera poteza
                        if (Metode.ProvjeriPotez(Strana.Bijeli, potezIgrača) == "")
                        {
                            Console.Clear();
                            //Console.WriteLine("Taj potez nije moguće odigrati!");
                            Process.Start("https://www.youtube.com/watch?v=7qnd-hdmgfk");
                            Console.ReadKey();
                        }
                    } while (Metode.ProvjeriPotez(Strana.Bijeli, potezIgrača) == "");
                    if (Ploča.statusIgre == false || Ploča.neriješeno == true) break;
                    //Odigravanje poteza ako se može odigrati
                    Metode.OdigrajPotez(Strana.Bijeli, potezIgrača);
                    Metode.ProvjeriThreefoldRepeticiju();
                    Metode.ProvjeriJelNeriješeno(Strana.Bijeli);
                    Metode.ProvjeriIIzvršiPromociju(Strana.Bijeli);
                }
                if (Ploča.statusIgre == false || Ploča.neriješeno == true) break;
                //Crni je na potezu
                if (brojac % 2 == 1)
                {
                    do
                    {
                        //Izračunavanje mogućih poteza
                        Metode.OčistiPotezeFigura();
                        Metode.IzračunajMogućePoteze(Strana.Crni);
                        Metode.IzračunajMogućePoteze(Strana.Bijeli);
                        Metode.ProvjeriŠah(Strana.Crni);
                        Metode.ProvjeriJelNeriješeno(Strana.Crni);
                        if (Ploča.statusIgre == false || Ploča.neriješeno == true) break;
                        //Ispis ploče
                        Console.Clear();
                        Metode.IspišiPločuPvP(brojac);
                        Console.WriteLine();
                        if (Ploča.jeŠah == true && Ploča.stranaUŠahu == Strana.Crni)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Šah!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        Console.Write("Crni igra: ");
                        //Unos poteza
                        potezIgrača = Console.ReadLine();
                        //Provjera poteza
                        if (Metode.ProvjeriPotez(Strana.Crni, potezIgrača) == "")
                        {
                            Console.Clear();
                            //Console.WriteLine("Taj potez nije moguće odigrati!");
                            Process.Start("https://www.youtube.com/watch?v=7qnd-hdmgfk");
                            Console.ReadKey();
                        }
                    } while (Metode.ProvjeriPotez(Strana.Crni, potezIgrača) == "");
                    if (Ploča.statusIgre == false || Ploča.neriješeno == true) break;
                    //Odigravanje poteza ako se može odigrati
                    Metode.OdigrajPotez(Strana.Crni, potezIgrača);
                    Metode.ProvjeriThreefoldRepeticiju();
                    Metode.ProvjeriJelNeriješeno(Strana.Bijeli);
                    Metode.ProvjeriIIzvršiPromociju(Strana.Crni);
                }
                brojac++;
            }
            Console.Clear();
            Console.WriteLine("Završetak igre!");
            if (Ploča.jeŠah == true && Ploča.stranaUŠahu == Strana.Bijeli)
            {
                Console.WriteLine("Pobjednik je Crni!");
            }
            if (Ploča.jeŠah == true && Ploča.stranaUŠahu == Strana.Crni)
            {
                Console.WriteLine("Pobjednik je Bijeli!");
            }
            if (Ploča.neriješeno == true && Ploča.jeŠah == false)
            {
                Console.WriteLine("Neriješeno!");
            }
            Console.ReadKey();
            Metode.OčistiPloču();
            */
        }
    }
}
