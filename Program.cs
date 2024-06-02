int myNumber = 367600;
string myString = myNumber.ToString();
string myString2 = "Podana liczba to :";

//string tekst = "Przykładowy tekst";
Dictionary<char, int> myCounter = new Dictionary<char, int>();

foreach (char znak in myString)
{
    if (myCounter.ContainsKey(znak))
    {
        myCounter[znak]++;
    }
    else
    {
        myCounter[znak] = 1;
    }
}

Console.WriteLine(myString2 + myString);
foreach (var para in myCounter)
{
    Console.WriteLine($"Znak {para.Key} wystepuje {para.Value} razy.");
}