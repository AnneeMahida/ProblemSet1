using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        // Question 1
        questionOne();
       

        // Question 2
        questionTwo();

        // Question 3
        questionThree();

    }
    static void questionOne()
    {
        Console.WriteLine("Question 1");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Data type of 5 is: " + 5.GetType());
        Console.WriteLine("Data type of 5.0 is: " + 5.0.GetType());
        Console.WriteLine("Data type of 5 > 1 is: " + (5 > 1).GetType());
        Console.WriteLine("Data type of '5' is: " + '5'.GetType());
        Console.WriteLine("Data type of 5 * 2 is: " + (5 * 2).GetType());
        Console.WriteLine("Data type of '5' * 2 is: " + ('5' * 2).GetType());
        Console.WriteLine("Data type of '5' + '2' is: " + ('5' + '2').GetType());
        Console.WriteLine("Data type of 5 / 2 is: " + (5 / 2).GetType());
        Console.WriteLine("Data type of 5 % 2 is: " + (5 % 2).GetType());
        Console.WriteLine("Data type of {5,2,1} is: " + new int[] { 5, 3, 1 }.GetType());
        Console.WriteLine("Data type of 5 == 3 is: " + (5 == 3).GetType());
        Console.WriteLine("Data type of pi(the number) is: " + (Math.PI).GetType());
        Console.WriteLine("---------------------------------------------------");
    }

    static void questionTwo()
    {
        String s1 = "Supercalifragilisticexpialidocious";
        String s2 = "Honorificabilitudinitatibus";
        String s3 = "Bababadalgharaghtakamminarronnkonn";
        String longestWord = "";
        String[] directory = {"Berlioz", "Borodin", "Brian","Bartok", "Bellini", "Buxtehude", "Bernstein"};
        Array.Sort(directory);

        Console.WriteLine("Question 2");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Total letters in 'Supercalifragilisticexpialidocious': " + s1.Length);
        Console.WriteLine("'Supercalifragilisticexpialidocious' contain 'ice': " + s1.Contains("ice"));
        if (s1.Length > s2.Length)
        {
            longestWord = s1;
        }
        else 
        { 
            longestWord = s2;
        }
        if (s3.Length > longestWord.Length)
        {
            longestWord = s3;
        }


        Console.WriteLine("Longest word is: " + longestWord);
        Console.WriteLine(directory[0]);
        Console.WriteLine(directory[directory.Length - 1]);


        Console.WriteLine("--------------------------------------------------");
    }

    static void questionThree ()
    {

        Console.WriteLine("Question 3");
        Console.WriteLine("--------------------------------------------------");
        char a = 'a';
        char b = 'b';
        char c = 'c';
        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Console.WriteLine("Enter the value of a: ");
        Console.WriteLine("Enter the value of b: ");
        Console.WriteLine("Enter the value of c: ");
        Console.Write("Area of the triangle is: " + area);


    }


}