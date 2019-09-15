using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!"); //Make the console say Hello, world! 
                                                //Make sure to type the comma because dats good grammar.
            int meaningOfLife = 42; //assign an integer variable.
            float smallPi = 3.14f; // assign a float and use f to specify that it's a float.
            double bigPi = 3.14159265359; //double because it's double the size. not really, it's just bigger. 
            string vaporWare = "Half Life 3"; //string because letters.
            bool likesPizza = true; //true or false
            string[] writers = { "Anthony", "Brian", "Eric", "Sean" }; //This is an array of strings. 
            string[] editors = new string[5];  // You can declare an array without assigning the values
            bool isMonster = (likesPizza == true) ? false : true; // this is a quicker way to assign a value. It's like an if statement.
            writers[0] = "Ray"; //This reassigns the first element of the array.

            Console.WriteLine(writers[2]); // this writes the second element of the array to the console. (Brian)
            if (likesPizza == false)
            {
                Console.WriteLine("You monster!"); // if likesPizza is false, dehumanize the user. 
            }

            // set up a for loop. declare a variable, // set up the boolean statement, and increment the variable.
            //This loops 10 times. 
            for (int i= 0; i < 10; i++) 
                                       
            {
                Console.WriteLine("C# Rocks!"); //Writes the message 10 times. 
            }
            
            //This loops through each element of the array and writes them.
            for (int i = 0; i < writers.Length; i++)
            {
                string writer = writers[i];
                Console.WriteLine(writer);
            }

            //Here's another kind of loop that is great for arrays.
            foreach (string writer in writers)
            {
                Console.WriteLine(writer);
            }

            if (meaningOfLife == 42)
            {
                bool inScope = true;
            }

            //inScope = false; //This will cause an error because it is out of scope.

            Point2D myPoint = new Point2D(); //declares new structure object
            myPoint.X = 10;
            myPoint.Y = 20;
            Point2D anotherPoint = new Point2D(); //declares a second structure object
            anotherPoint.X = 5;
            anotherPoint.Y = 15;

            myPoint.AddPoint(anotherPoint); //passes the second structure object to the AddPoint function of the first object

            Point2D yetAnotherPoint = myPoint; //assigns a new object to the same location as myPoint
            yetAnotherPoint.X = 100; //assigns the x to 100;

            Console.WriteLine(myPoint.X);
            Console.WriteLine(yetAnotherPoint.X);

            Point2DRef pointRef = new Point2DRef();
            pointRef.X = 20;
            Point2DRef anotherRef = pointRef;
            anotherRef.X = 25;
            //Both pointRef and anotherRef x will be assigned to 25 because of the way class memory works. 
            pointRef = null;//even though this is set to null, the class object still has a reference with anotherRef
            anotherRef.X = 125; // You can still set this. 
            Console.WriteLine(anotherRef.X); // write it
            anotherRef = null; // now the class is null

            RenFairePerson person = new RenFairePerson(); //Adds a class object
            person.Name = "Igor the Ratcatcher"; //assigns a name in the class (to an existing string variable)
            person.SayHello(); //calls the sayHello() function but it's overrided to say Huzzah!
        } 
    }
}
struct Point2D //This is a structure
{
    public int X;
    public int Y;
    public void AddPoint (Point2D anotherPoint) // moves a point to another point (passes an object)
    {
        this.X = this.X + anotherPoint.X;
        this.Y = this.Y + anotherPoint.Y;
    }
}

class Point2DRef //this is a class instead of a structure
{
    public int X;
    public int Y;
    public void AddPoint(Point2DRef anotherPoint)
    {
        this.X = this.X + anotherPoint.X;
        this.Y = this.Y + anotherPoint.Y;
    }
}

class Person
{
    public string Name; //A class that has a function to write "Hello"
    public virtual void SayHello()
    {
        
        Console.WriteLine("Hello");
    }
}

class RenFairePerson : Person //This extends Person
{
    public override void SayHello() //overrides sayHello() and makes it say Huzzah instead.
    {
        base.sayHello(); //Will print hello first
        Console.Write("Huzzah!");
    }
}

/* You can also just say var and c# is pretty good at figuring out what kind of variable it should be. 
var  meaningOfLife = 42; 
var  smallPi = 3.14f; 
var  bigPi = 3.14159265359; 
var  vaporWare = "Half Life 3"; 
var  likesPizza = true;
*/

