using System;

string answer1;
string answer2;
string answer3;


int points = 0;
Console.WriteLine("Välkommen till Mickes transformers-frågesport!");

// -----------------------------------------------------------------------------

Console.WriteLine("1: Vad gillar Bakk att käka till lunch?");
Console.WriteLine("a) Nyttig mat  b) Ben & Jerry  c) Normal mat");
answer1 = Console.ReadLine();
if (answer1 == "b")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine("2: Vad är bakks dröm?");
Console.WriteLine("a) Att bli väl tränad  b) Att få en partner  c) Att bli smällfet");
answer2 = Console.ReadLine();
if (answer2 == "c")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine("3: Vad kommer bullen Bakk jobba med i framtiden?");
Console.WriteLine("a) Spelutvecklare på Fortnite b) Sopgubbe  c) Civil ingenjör");
answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}

// -----------------------------------------------------------------------------

Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du har alltså ingen koll alls.");
}
else if (points < 3)
{
  Console.WriteLine("OK, du har hyfsad koll - eller gissade rätt en eller ett par gånger.");
}
else 
{
  Console.WriteLine("Grattis! Du hade alla rätt!");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();