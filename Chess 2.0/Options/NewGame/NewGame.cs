using Chess_2._0.Options.NewGame.GameModes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Chess_2._0.Options.NewGame
{
    internal static class NewGame
    {
        public static void NewGameSelect()
        {
            Console.Clear();
            Console.Write("Choose game mode(PvP/PvE): ");
            string izborVrsteIgre = Console.ReadLine();
            switch (izborVrsteIgre)
            {
                case "pvp":
                    PvP.StartPvpGame(); break;
                case "pve":
                    PvE.StartPveGame(); break;
            }
        }
    }
}
