
using System;
using System.IO;
using System.Text;
using System.Numerics;
using System.Threading.Channels;
using Rechner;
using System.ComponentModel.Design;


string Entry;


double Zahl1;
bool isZahl1;
double Zahl2;
bool isZahl2;

do
{
Start:
    Console.WriteLine("--------------------------");
    Console.WriteLine("Was möchtest du berechnen? \nFür alle Befehle gib \"help\" ein!");
    Console.WriteLine("--------------------------");


    Entry = Console.ReadLine();
    if (Entry == "help")
    {
        Console.WriteLine("\n Addition (add) \n Subtraktion (sub) \n Multiplikation (multi) \n Division (div) \n Restbetrag (rest) \n\n Verlauf (log) \n Verlauf leeren (clear) \n Beenden (exit)");
    }
    else if (Entry == "add")
    {
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl1 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl1);
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl2 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl2);
        double resultAdd = Zahl1 + Zahl2;
        if (!isZahl1 || !isZahl2)
        {
            ConsoleAndFile.WriteLine("\nEine der Eingaben ist keine Zahl!\n");
            goto Start;
        }
        else
        {
            ConsoleAndFile.WriteLine("\nDas Ergebnis lautet: " + Zahl1 + "+" + Zahl2 + "=" + resultAdd + "\n");
        }
    }
    else if (Entry == "sub")
    {
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl1 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl1);
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl2 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl2);
        double resultSub = Zahl1 - Zahl2;
        if (!isZahl1 || !isZahl2)
        {
            ConsoleAndFile.WriteLine("\nEine der Eingaben ist keine Zahl!\n");
            goto Start;
        }
        else
        {
            ConsoleAndFile.WriteLine("\nDas Ergebnis lautet: " + Zahl1 + "-" + Zahl2 + "=" + resultSub + "\n");
        }
    }
    else if (Entry == "multi")
    {
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl1 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl1);
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl2 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl2);
        double resultMulti = Zahl1 * Zahl2;
        if (!isZahl1 || !isZahl2)
        {
            ConsoleAndFile.WriteLine("\nEine der Eingaben ist keine Zahl!\n");
            goto Start;
        }
        else
        {
            ConsoleAndFile.WriteLine("\nDas Ergebnis lautet: " + Zahl1 + "*" + Zahl2 + "=" + resultMulti + "\n");
        }
    }
    else if (Entry == "div")
    {
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl1 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl1);
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl2 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl2);
        double resultDiv = Zahl1 / Zahl2;
        if (!isZahl1 || !isZahl2)
        {
            ConsoleAndFile.WriteLine("\nEine der Eingaben ist keine Zahl!");
            goto Start;
        }
        else
        {
            ConsoleAndFile.WriteLine("\nDas Ergebnis lautet: " + Zahl1 + "/" + Zahl2 + "=" + resultDiv + "\n");
        }
    }
    else if (Entry == "rest")
    {
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl1 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl1);
        Console.Write("Gib nachfolgend eine Zahl ein: ");
        isZahl2 = Double.TryParse(ConsoleAndFile.ReadLine(""), out Zahl2);
        double resultRest = Zahl1 % Zahl2;
        if (!isZahl1 || !isZahl2)
        {
            ConsoleAndFile.WriteLine("Eine der Eingaben ist keine Zahl!\n");
            goto Start;
        }
        else
        {
            ConsoleAndFile.WriteLine("\nDas Ergebnis lautet: " + Zahl1 + "%" + Zahl2 + "=" + resultRest + "\n");
        }
    }
    else if (Entry == "log")
    {
        String line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("C:\\Users\\Umschueler\\source\\repos\\Konsole\\Konsole\\log.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Der Verlauf wird angezeigt");
        }
    }

    else if (Entry == "cClear")
    {
        Console.Clear();
    }
    else if (Entry == "clear")
    {
        System.IO.File.WriteAllText("C:\\Users\\Umschueler\\source\\repos\\Konsole\\Konsole\\log.txt", string.Empty);
        Console.WriteLine("Der Log wurde gelöscht");
    }
    else if (Entry == "exit")
    {
        Console.WriteLine("Das Programm wurde beendet!");
    }
    else
    {
        Console.WriteLine("Falsche Eingabe!\n");
    }





}

while (Entry != "exit");





