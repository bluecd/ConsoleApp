﻿int[] grades = new int[365];

List<string> dayOfWeek = new List<string>();
dayOfWeek.Add("poniedzialek");
dayOfWeek.Add("wtorek");
dayOfWeek.Add("sroda");
dayOfWeek.Add("czwartek");
dayOfWeek.Add("piatek");
dayOfWeek.Add("sobota");
dayOfWeek.Add("niedziela");

//Console.WriteLine(dayOfWeek[2]);

//Console.WriteLine(dayOfWeek[0]); 

for (int i = 0; i < dayOfWeek.Count; i++)
{
    Console.WriteLine(dayOfWeek[i]);
}