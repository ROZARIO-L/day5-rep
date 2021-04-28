/*Create a C# program that implements an IVehichle interface with two methods, one for Drive of type void and another for Refuel of type 
bool that has a parameter of type integer with the amount of gasoline to refuel. Then create a Car class with a builder that receives a 
parameter with the car's starting gasoline amount and implements the Drive and Refuel methods of the car.
The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0. 
The Refuel method will increase the gasoline of the car and return true.
To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program and
ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car.
*/

using System;
interface Ivehicle
{
	void Drive();
	bool Refuel(int addfuel);
}
public class Car : Ivehicle
{
int intialfuel;
public void Drive()
{
if(intialfuel>0)
{
Console.WriteLine("car is Driving");
}
else
{
Console.WriteLine("car has no fuel");
}
}
public bool Refuel(int addfuel)
{
intialfuel  += addfuel;
return true;
}
public Car(int a)
{
intialfuel=a;
}
 public static void Main(string[] args)
{
	Console.WriteLine("car's starting gasoline amount:");
	int _intialfuel=Convert.ToInt32(Console.ReadLine());
 	Car benz = new Car(_intialfuel);
	benz.Drive();
	
}
}


