
// See https://aka.ms/new-console-template for more information
using testy;
using System;




internal class Program
{
    Generate generate = new Generate();
    TestNumber testNumber = new TestNumber();
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Generate.Gener();
        TestNumber.perfectTest();
        Console.ReadLine();
}
}

//c-sharp program scaffold:





//static void GenerateRange()
//{
//    Console.WriteLine("enter lower bound integer: ");
//    int minimum = int.Parse(Console.ReadLine());

//    Console.WriteLine("enter max value");
//    int maximum = int.Parse(Console.ReadLine());


//    for (int number = minimum; number < maximum - 1; number++)
//    {
//        int sum = 0;
//        for (int n = 1; n < number - 1; n++)
//        {
//            if (number % n == 0)
//            {
//                sum += n;
//            }
//        }
//        if (sum == number)
//        {
//            Console.WriteLine($"number {number} is perfect.");


//        }
//    }

//}

//GenerateRange();