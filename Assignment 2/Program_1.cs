using System;

namespace temp
{

    static class  Program_1

{


public  static  void  add(int  a,  int  b)

{

int c  =  a  +  b; Console.WriteLine(c);

}

public  static  void  sub(int  a,  int  b)

{

int d  =  a  - b; 

Console.WriteLine(d);
}



public  static  void  mul(int  a,  int  b)
{
int e  =  a  * b; Console.WriteLine(e);
}
 

public  static  void  div(int  a,  int  b)
{
int f =  a  / b; Console.WriteLine(f);
}

public  static  void  complex(int  a,  int b, int  c)
{
int g  =  a  +  b  * c; Console.WriteLine(g);
}

public  static  void  complex2(int  a,  int  b,  int  c,  int  d)
{
int e  =  (a  +  b)  / c;
int f =  (a  +  b)  %   c;

Console.WriteLine($"quotient  : {e}"); Console.WriteLine($"remainder  : {f}");
}

public  static  void  findMinMax()
{
int max  =  int.MaxValue;
int min  =  int.MinValue;
Console.WriteLine($"The  range  of  integers  is  {min}  to  {max}");
}
public  static  void  doubleArithametics(double  x,  double  y,  double  z)
{
double  d  =  (x  +  y)  / z;
Console.WriteLine($"double  expresion  (a+b)/c=  {d}");
}
public  static  void  minMax()
{
double  max  =  double.MaxValue;
double  min  =  double.MinValue;
Console.WriteLine($"The  range  of  double  is  {min}  to  {max}");

}
public  static  void  roundingError()
{
double  third  =  1.0  / 3.0;
Console.WriteLine($"rounding  error  in  double  {third}");

}
public  static  void  decimalMinMax()
{
decimal  min  =  decimal.MinValue;
decimal  max  =  decimal.MaxValue;
Console.WriteLine($"The  range  of  the  decimal  type  is  {min}  to  {max}");
}
public  static  void  decimalVsDouble()
{
double  a  =  1.0;
 


double  b  =  3.0; Console.WriteLine($"Double{a  / b}");

decimal  c  =  1.0M; decimal  d  =  3.0M; Console.WriteLine($"Decimal{c  / d}");

}
public  static  void  areaOfCircle()
{
double  radius  =  2.50;
double  area  =  Math.PI  * radius  * radius; Console.WriteLine(area);
}

}

}