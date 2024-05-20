
using System.ComponentModel.Design;

var myName = "Zbigg";
var mySex = "mezczyzna";
var myAge = 54;

if (mySex == "kobieta" && myAge < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (myName == "Ewa" && myAge == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (mySex == "mezczyzna" && myAge < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
