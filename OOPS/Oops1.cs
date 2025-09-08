using System;

namespace Oops1
{
    class Oops1
    {
        // Class and Object
        class Car
        {
            public string color;
            public string model;

            public void displayInfo()
            {
                Console.WriteLine($"Car Model: {model}, Color: {color}");
            }
        }

        class player
        {
            public string name = "Tommy";
            public int health = 49;
            public void setHealth (int health)
            {
                this.health = health;
            }
        }

        static void Main(string[] args)
        {
            /*
            Object Oriented Programming System (OOPS) in C# :-
            1. Class and Object
            2. Constructor
            3. Inheritance
            4. Polymorphism
            5. Abstraction
            6. Encapsulation
            */

            Car car1 = new Car();
            car1.model = "Toyota";
            car1.color = "Red";
            car1.displayInfo();

            Car car2 = new Car();
            car2.model = "Honda";
            car2.color = "Blue";
            car2.displayInfo();

            player p1 = new player();
            Console.WriteLine($"Player Name: {p1.name}, Health: {p1.health}");


            Console.ReadLine();
        }
    }
}