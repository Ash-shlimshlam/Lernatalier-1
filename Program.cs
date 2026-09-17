using System;
using System.ComponentModel;

var translations = new Dictionary<string, string>
{
    ["un assasin"] = "ein Mörder.",
    ["en haut"] = "oben.",
    ["l'ouest"] = "West.",
    ["le nord"] = "Norden.",
    ["le sud"] = "Süden."
};
do
{
    Random random = new Random();
    string heading = translations.Keys.ElementAt(random.Next(translations.Count));
    string instructions = translations[heading];
    Console.WriteLine("Übersetze " + instructions);
    string answer;
    answer = Console.ReadLine();
    if (answer == heading) { Console.WriteLine("correct"); translations.Remove(heading); } else { Console.WriteLine("false " + heading); }
} while (translations.Count > 0);

    

