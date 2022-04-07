using System;

namespace ne
{
   class Fraction

{




private int numerator,denominator;

public Fraction(int a,int b){ this.denominator = b; this.numerator = a; if(b==0){
throw new DivideByZeroException();
 


}

}

public double FloatingDivision(){

return ((float)numerator/denominator);

}




public void SimplifyFraction(){

int gcd = 0;

for(int i=1;i<denominator;i++){

if(numerator%i==0 && numerator%i == 0){

gcd = i;

}

}




Console.WriteLine($"Integer division result= {numerator/gcd}/{denominator/gcd}");

}



public void IntegerDivison(){ Console.WriteLine($"Integer division result ={(int)numerator/denominator} with a remainder {numerator%denominator}");

}

public void ReduceFraction(){

int wholeNum = (int)numerator/denominator;
 


Console.WriteLine($"The result as a mixed fractionis = {wholeNum} {numerator%denominator}/{denominator}");

}

}




}




