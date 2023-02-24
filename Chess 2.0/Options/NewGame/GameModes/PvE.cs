using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chess_2._0.Options.NewGame.GameModes
{
    internal static class PvE
    {
        internal static void StartPveGame()
        {
            Console.Clear();
            Console.WriteLine("You chose PVE");
            Console.ReadLine();
            /*
            Console.Clear();
            //Biranje strane (B/C)
            Console.Write("Izaberite stranu (B/C): ");
            string izborStrane = Console.ReadLine();
            //Igrač je bijeli
            if (izborStrane == "B" || izborStrane == "b")
            {
                Console.Clear();
                Metode.KreirajFigure();
                Metode.KreirajPloču();
                Metode.PosložiFigure();
                Metode.IspišiPločuPvE(Strana.Bijeli);
                Console.ReadKey();
                while (Ploča.statusIgre == true)
                {
                    string potezIgrača = Console.ReadLine();
                    Metode.OdigrajPotezBOT();
                }
            }
            //Igrač je crni
            if (izborStrane == "C" || izborStrane == "c")
            {
                Console.Clear();
                Metode.KreirajFigure();
                Metode.KreirajPloču();
                Metode.PosložiFigure();
                Metode.IspišiPločuPvE(Strana.Crni);
                Console.ReadKey();
                while (Ploča.statusIgre == true)
                {
                    Metode.OdigrajPotezBOT();
                    string potezIgrača = Console.ReadLine();
                    for (int i = 0; i < 3; i++)
                    {
                        //treba provjerit unos igrača, proučit šahovsku notaciju do kraja
                    }
                }
            }
            */
        }
    }
}
