using System;
using System.ComponentModel;

var Voci = new Dictionary<string, string>
{
    ["un auteur/une auteure"] = "ein Autor/eine Autorin",
    ["international/internationale/internationaux/internationales"] = "International",
    ["un sport extrem"] = "ein Extremsport",
    ["une compétition"] = "ein Wettkampf",
    ["le monde"] = "die Welt",
    ["entier/entière"] = "ganz,völlig",
    ["exister"] = "existieren",
    ["un monument"] = "ein Monument",
    ["ouvert/ouverte"] = "offnen/geöffnet",
    ["la lumière"] = "das Licht"
};

    do
{
    Random random = new Random();
    string French_translations = Voci.Keys.ElementAt(random.Next(Voci.Count));
    string German_translations = Voci[French_translations];
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" //Übersetze: " + German_translations + "//");
    string answer;
    answer = Console.ReadLine();
   
    if (answer == French_translations) 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("richtig!"); Voci.Remove(French_translations);
     
     
        
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine ("falsch, die Antwort wäre; " + French_translations);
      
    }
} while (Voci.Count > 0);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Sie haben alle Wörter erfolgreich übersetzt!");



    

