/*1. Write a program to check whether a triangle is Equilateral, Isosceles or
Scalene.
2. Write a program to read 10 numbers and find their average and sum.
3. Write a program to display the multiplication table of a given integer.
4. Write a program to display a pattern like triangles with a number.
5. The patterns like :1             1                 1
                      12            23             2     3
                      123           456          4    5    6
                      1234          78910     7    8     9    10
                      12345
6. Write a program to display the n terms of harmonic series and their
sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
7. Write a program to find the ‘perfect’ numbers within a given number
range.
8. Write a program to determine whether a given number is prime or not.
*/
//1. This is a simple C# console application that checks whether a triangle is Equilateral, Isosceles, or Scalene based on the lengths of its sides.
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");
        Console.Write("Side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Side C: ");
        double sideC = Convert.ToDouble(Console.ReadLine());
if (sideA == sideB && sideB == sideC)
{
    Console.WriteLine("The triangle is Equilateral.");
}
else if (sideA == sideB || sideB == sideC || sideA == sideC)
{
    Console.WriteLine("The triangle is Isosceles.");
}
else
{
    Console.WriteLine("The triangle is Scalene.");
}

//2.Write a program to read 10 numbers and find their average and sum.
        Console.WriteLine("Enter 10 numbers:");
        double sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            double number = Convert.ToDouble(Console.ReadLine());
            sum += number;
        }
        double average = sum / 10;
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
//3. Write a program to display the multiplication table of a given integer.
        Console.Write("Enter an integer to display its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Multiplication Table of {num}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
}

//4. Write a program to display a pattern like triangles with a number.
        Console.Write("Enter the number of rows for the triangle pattern: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
}
//5. The patterns like :
int rows1 = 4;

// Pattern 1
Console.WriteLine("Pattern 1:");

for (int i = 1; i <= rows1; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }

    Console.WriteLine();
}

Console.WriteLine();

// Pattern 2
Console.WriteLine("Pattern 2:");

int num1 = 1;

for (int i = 1; i <= rows1; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(num1 + " ");
        num1++;
    }
    Console.WriteLine();
}
// Pattern 3
int rows2 = 4;
int num2 = 1;

for (int i = 1; i <= rows2; i++)
{
    // In khoảng trắng đầu dòng
    for (int space = 1; space <= rows2 - i; space++)
    {
        Console.Write(" ");
    }

    // In số
    for (int j = 1; j <= i; j++)
    {
        Console.Write(num2 + " ");
        num2++;
    }

    Console.WriteLine();
}
