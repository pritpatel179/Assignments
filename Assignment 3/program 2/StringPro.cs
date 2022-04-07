using System;




namespace ne4{




class StringPro

{
 








public static int Length(string s){

return s.Length;

}




public static bool isDeclarative(string s){

return s[s.Length-1] == '.';

}




public static bool isInterrogative(string s){

return s[s.Length-1] == '?';

}




public static bool isExclamation(string s){

return s[s.Length-1] == '!';

}




public static void PrintName(string s){
string[] arr = s.Split(" "); Console.WriteLine($"You have entered name\'{arr[1]},{arr[0]}\'");

}
 


public static void EnhancedPrintName(string s){

string[] arr = s.Split(" ");

if(arr.Length == 1){

Console.WriteLine($"You have entered name\'{arr[0]}\'");

}else{

Console.WriteLine($"You have entered name\'{arr[1]},{arr[0]}\'");

}




}




}




}
