using System.IO;
/* *************************************************
 * Namn: CitatGenerator
 * Beskrivning: Ett program för att slumpa fram kända citat
 * Av: Max
 *********************************************** */

Console.Clear();

string filnamn = "quotes.txt";


// Programloop
    // Meny

    // Switch-sats

/* ************************************************
 * **************** Metoder ***********************
 ************************************************* */

static void SlumpaCitat(string filnamn = "quotes.txt") {
    string[] citat = File.ReadAllLines(filnamn);
    if (citat == null) {
        Console.WriteLine(citat);
    }
    

 }



 /* Karims Svar */

List<string> rader = File.ReadAllLines("quotes.txt").ToList<string>();
List<string> citatLista = new List<string>();

string citat = "";

foreach (var rad in rader)
{

    if (rad != null)
    {
        citat += rad;
    }
    else
    {
        citatLista.Add(citat);
        citat = "";
    }
}

 Console.ReadLine();