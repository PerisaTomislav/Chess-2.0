using Chess_2._0.Options;
using Chess_2._0.Options.NewGame;
using System;


Console.OutputEncoding = System.Text.Encoding.Unicode;
string choice;
do
{
    Console.Clear();
    Console.WriteLine("Chess");
    Console.WriteLine("---");
    Console.WriteLine();
    Console.WriteLine("1.New game");
    Console.WriteLine("2.Continue");
    Console.WriteLine("3.Analyse");
    Console.WriteLine("4.Help");
    Console.WriteLine("5.Settings");
    Console.WriteLine("6.Exit");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Choose an option: ");
    choice = Console.ReadLine();
    Console.Clear();
    switch (choice)
    {
        case "1": Console.Clear(); NewGame.NewGameSelect(); break;
        case "2": Console.Clear(); ContinueGame.Continue(); break;
        case "3": Console.Clear(); AnalyseGame.Analyze(); break;
        case "4": Console.Clear(); Help.ShowHelp(); break;
        case "5": Console.Clear(); Settings.ShowSettings(); break;
    }
} while (choice != "6");