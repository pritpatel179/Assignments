using System;

using ne;

namespace ne3

{

class Main_Program

{

public static void Main(){

Console.WriteLine("Please enter the numerator?");

int numerator = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Please enter the denominator?");
int denominator = Convert.ToInt32(Console.ReadLine()); Fraction F = new Fraction(numerator,denominator);
Console.WriteLine($"Floating point division result ={F.FloatingDivision()}");
 





F.IntegerDivison();

F.ReduceFraction();

}

}




}

