/*
 1. Write a C# Sharp program to check whether a given number is even or
odd.
2. Write a C# Sharp program to find the largest of three numbers.
3. Write a C# Sharp program to accept a coordinate point in an XY
coordinate system and determine in which quadrant the coordinate
point lies.
*/

// C# Sharp program to check whether a given number is even or odd.

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    
// C# Sharp program to find the largest of three numbers.
        
Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int largest = num1;
        if (num2 > largest)
        {
            largest = num2;
        }
        if (num3 > largest)
        {
            largest = num3;
        }
        Console.WriteLine($"The largest number is: {largest}");

// C# Sharp program to accept a coordinate point in an XY
// coordinate system and determine in which quadrant the coordinate
// point lies.
Console.Write("Enter the X coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("The coordinate point lies in the first quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The coordinate point lies in the second quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The coordinate point lies in the third quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The coordinate point lies in the fourth quadrant.");
        }
        else
        {
            Console.WriteLine("The coordinate point lies on the axis.");
        }