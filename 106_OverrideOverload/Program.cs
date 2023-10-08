using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Shape
{
    public abstract void Draw();           // Abstract method for drawing a shape (overriding happens in derived classes)
    public abstract double CalculateArea(); // Abstract method for calculating the area of a shape (overriding happens in derived classes)
    public abstract double CalculatePerimeter(); // Abstract method for calculating the perimeter of a shape (overriding happens in dervied classes)
}

class Circle : Shape
{
    private double radius; // Private field to store the radius of the circle

    public Circle(double r)
    {
        radius = r;
    }

    public override void Draw() // Method overriding: Override the Draw method in the base class
    {
        Console.WriteLine($"Drawing a circle with radius {radius}");
    }

    public override double CalculateArea() // Method overriding: Override the CalculateArea method in the base class
    {
        return Math.PI * radius * radius; // Calculate and return the area of the circle
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius; // Calculate and return the circumference of the circle
    }
}


class Rectangle : Shape
{
    private double width;  // Private field to store the width of the rectangle
    private double height; // Private field to store the height of the rectangle

    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
    }

    public override void Draw() // Method overriding: Override the Draw method in the base class
    {
        Console.WriteLine($"Drawing a rectangle with width {width} and height {height}");
    }

    public override double CalculateArea() // Method overriding: Override the CalculateArea method in the base class
    {
        return width * height; // Calculate and return the area of the rectangle
    }
    public override double CalculatePerimeter() // Method to calculate the perimeter of the rectangle
    {
        return 2 * (width + height); // Calculate and return the perimeter of the rectangle
    }
}
class Program
{
    static void Main(string[] args)
    {
        bool continueCalculations = true; // Variable to control whether to continue calculations or exit the program

        while (continueCalculations)
        {
            // Display menu to the user
            Console.WriteLine("Choose a shape to draw: ");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine()); // Read user choice
            Shape shapeToDraw = null; // Variable to store the selected shape

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the radius of the circle: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapeToDraw = new Circle(radius); // Create a Circle object with the provided radius
                    break;
                case 2:
                    Console.Write("Enter the width of the rectangle: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the rectangle: ");
                    double height = double.Parse(Console.ReadLine());
                    shapeToDraw = new Rectangle(width, height); // Create a Rectangle object with the provided width and height
                    break;
                case 3:
                    continueCalculations = false; // Set continueCalculations to false to exit the loop and end the program
                    break;
                default:
                    Console.WriteLine("Invalid choice!"); // Display a message for invalid input and continue the loop
                    continue;
            }

            if (shapeToDraw != null) // Check if a shape object is created
            {
                shapeToDraw.Draw(); // Call the Draw method of the selected shape
                double area = shapeToDraw.CalculateArea(); // Call the CalculateArea method to calculate the area of the shape
                Console.WriteLine($"Area of the shape: {area}"); // Display the calculated area to the user
                double perimeter = shapeToDraw.CalculatePerimeter(); // Call the CalculatePerimeter method to calculate the area of the shape
                Console.WriteLine($"Perimeter of the shape: {perimeter}"); // Display the calculated area to the user
            }
        }
    }
}