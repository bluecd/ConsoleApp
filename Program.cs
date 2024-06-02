int myNumber = 367600;
string myString = myNumber.ToString();
string myString2 = "Podana liczba to :";

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
foreach (var myPair in myCounter)
{
    Console.WriteLine($"myDigit {myPair.Key} wystepuje {myPair.Value} razy.");
}