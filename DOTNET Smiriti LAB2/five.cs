using System;

namespace VirtualMethodDemo
{
    // Base class
    class Animal
    {
        // Virtual method
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Overriding the virtual method
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Another derived class
    class Cat : Animal
    {
        // Overriding the virtual method
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Creating objects of base and derived classes
        //    Animal myAnimal = new Animal();
        //    Animal myDog = new Dog();
        //    Animal myCat = new Cat();

        //    // Calling the Speak method on different objects
        //    myAnimal.Speak(); // Output: Animal makes a sound.
        //    myDog.Speak();    // Output: Dog barks.
        //    myCat.Speak();    // Output: Cat meows.

        //    Console.ReadLine();
        //}
    }
}
