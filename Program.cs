int myNumber = 367600;
string myString = myNumber.ToString();
string myString2 = "Podana liczba to :";

//string tekst = "Przykładowy tekst";
Dictionary<char, int> myCounter = new Dictionary<char, int>();

foreach (char myDigit in myString)
{
    if (myCounter.ContainsKey(myDigit))
    {
        myCounter[myDigit]++;
    }
    else
    {
        myCounter[myDigit] = 1;
    }
}

Console.WriteLine(myString2 + myString);
foreach (var para in myCounter)
{
    Console.WriteLine($"myDigit {para.Key} wystepuje {para.Value} razy.");
}