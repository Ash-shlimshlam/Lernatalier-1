// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Runtime;
int roll;
do
{
    Random Word = new Random();
    roll = Word.Next(1, 3);
    if (roll == 1)
    {
     
        string wort = "oben";
        Console.WriteLine("Übersetze 'Oben'");
        string antwort;
        antwort = Console.ReadLine();
        if (antwort == "en haut") { Console.WriteLine("Correct!"); } else { Console.WriteLine("Antwort ist 'en haut'"); }
    }
    if (roll == 2)
    {
       
        string wort = "ein Mörder";
        Console.WriteLine("Übersete 'ein Mörder'");
        string antwort;
        antwort = Console.ReadLine();
        if (antwort == "un assasin") { Console.WriteLine("Correct!"); } else { Console.WriteLine("Antwort ist 'un assasin"); }
    }
} while (roll < 3);
