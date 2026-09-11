using System;

var translations = new Dictionary<string, string>
{
    ["un assasin"] = "ein Mörder.",
    ["en haut"] = "oben.",
    ["l'ouest"] = "West.",
    ["le nord"] = "Norden.",
    ["le sud"] = "Süden."
};
Random random = new Random();
string heading = translations.Keys.ElementAt(random.Next(translations.Count));
string instructions = translations[heading];
Console.WriteLine("Übersetze " + instructions);
string answer;
answer = Console.ReadLine();
if (answer == heading) { Console.WriteLine("correct"); } else { Console.WriteLine("false"); }


