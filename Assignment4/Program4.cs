using System; 

using ne8; 

namespace ne9{

class Program{ 
public static void Main1(){ 
const string name = "Patel Prit"; 
Console.WriteLine($"name: {name},Time: {DateTime.Now.ToString("HH:mm:ss tt")}");



TimePeriod t = new TimePeriod(); 
t.Hours = 3; 
Console.WriteLine($"Time in hours: {t.Hours}"); 
var person = new Person("Patel", "Prit"); 
Console.WriteLine(person.Name); 
var item = new SaleItem("Shoes", 35.99m); 
Console.WriteLine($"{item.Name}: sells for {item.Price:C2}"); 
var autoImplementedItem = new AutoImplementedSaleItem{ Name = "Socks", Price = 25.49m }; 
Console.WriteLine($"{autoImplementedItem.Name}: sells for {autoImplementedItem.Price:C2}"); 
} 
} 
}
