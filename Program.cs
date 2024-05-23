int[] grades = new int[365];
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "poniedzialek";
dayOfWeek[1] = "wtorek";
dayOfWeek[2] = "sroda";
dayOfWeek[3] = "czwartek";
dayOfWeek[4] = "piatek";
dayOfWeek[5] = "sobota";
dayOfWeek[6] = "niedziela";
//Console.WriteLine(dayOfWeek[2]);

//Console.WriteLine(dayOfWeek[0]); 

for (int i = 0; i < dayOfWeek.Length; i=i++)
{
    Console.WriteLine(dayOfWeek[i]);
}