using System;

class Program {
  public static void Main (string[] args) {
    int counter = 0;

while(counter < 7){
 Console.WriteLine("Enter number of cars:");
    double car = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Enter distance covered by Car:");
    double Miles = Convert.ToDouble(Console.ReadLine());
    
   Console.WriteLine("Enter the time taken by Car:");  
    double Hours = Convert.ToDouble(Console.ReadLine());

    double Car1 = Miles / Hours; 

    Console.WriteLine("Amount of cars: " + car);
    Console.WriteLine( "All going at a speed of " + Car1);
counter++;
}





  }
}