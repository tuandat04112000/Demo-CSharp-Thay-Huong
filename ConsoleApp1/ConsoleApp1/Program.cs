using System;
 
namespace ConsoleApp1
{
    class Program
    {
        static protected string s ="Hello World";// demo Access specifier
        static void Main(string[] args)
        {
            Car myO = new Car();
            //Console.WriteLine(myO.model);
            myO.nameCar(); // demo phần kế thừa

                Animal myAnimal = new Animal();  // Create a Animal object
                Animal myPig = new Pig();  // Create a Pig object
                Animal myDog = new Dog();  // Create a Dog object

                //demo phần bao đóng

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();
        }
    }
    class Car : Program
    {
        protected string model = "Ferrari";

        public void nameCar(){
            Console.WriteLine(s);
        }
    }

    class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}
}
