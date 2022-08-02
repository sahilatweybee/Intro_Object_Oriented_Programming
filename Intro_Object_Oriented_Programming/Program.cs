using System;
using Animal1;
using Employee_Info;
using AccessModifiers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal1
{
    interface IAnimal
    {
        void eat();
    }
    abstract class Earthling // : IAnimal throws compiler Error
    {
        //public virtual void eat() { Console.WriteLine("Eating..."); }
        public abstract void run();
    }

    class Mammal : Earthling, IAnimal // single level inhritance ////////multiple inheritance using Interface
    {
        public void reproduce() { Console.WriteLine("Gives Birth."); }
        public sealed override void run() { Console.WriteLine("Earthling Mammals can run because they have legs"); }
        public virtual void eat() { Console.WriteLine("Eats Food."); }
    }

    sealed class Dog : Mammal // multi level inheritance
    {
        public void bark() { Console.WriteLine("Barking..."); }
        // public override void run() { } can't override because it's sealed
        public override void eat()
        {
            base.eat();
            Console.WriteLine("Eats Bread, Meat, Bone etc.");
        }
    }

    // public class BabyDog : Dog { } can't derive a sealed class
}

namespace Employee_Info
{
    class Address
    {
        protected internal string addressLine, city, state;
        public static string country;
        public Address(string Addr, string city, string state)
        {
            this.addressLine = Addr;
            this.city = city;
            this.state = state;
        }
    }

    class Employee
    {
        public int id;
        public string name;
        public Address add;//Employee HAS-A Address  
        public Employee(int id, string name, Address ad)
        {
            this.id = id;
            this.name = name;
            this.add = ad;
        }
        public void display()
        {
            Console.WriteLine("\nID: " + id + "\nName: " + name + "\nAddress: " +
              add.addressLine + ",\n\t " + add.city + ", " + add.state + ", " + Address.country);
        }
    }

    class Calculate
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}

namespace AccessModifiers
{
    class Student
    {
        internal int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

namespace Intro_Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.bark();
            d1.reproduce();
            d1.eat();
            

            Address a = new Address("4373 wilkinson Street", "Nashville", "Tennessee");
            Address.country = "USA";
            Employee e = new Employee(32, "John", a);
            e.display();

            Calculate cl = new Calculate();
            Console.WriteLine("\n2 Parameters: " + cl.add(12, 15));
            Console.WriteLine("3 Parameters: " + cl.add(12, 15, 19));

            Student st = new Student();

            st.ID = 103;
            st.Name = "Sahil";
            st.Email = "sahil@gmail.com";

            Console.WriteLine("\nID = " + st.ID);
            Console.WriteLine("Name = " + st.Name);
            Console.WriteLine("Email = " + st.Email);

            Console.ReadLine();
        }
    }
}

