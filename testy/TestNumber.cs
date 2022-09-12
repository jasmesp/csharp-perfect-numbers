namespace testy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestNumber
{
    public static void perfectTest()
    {
        //get integer from user:
        Console.WriteLine("Enter a number to test for perfectness: ");
        int number = Convert.ToInt32(Console.ReadLine());
        //test number if perfect:
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        if (sum == number)
        {
            Console.WriteLine("The number is perfect.");
        }
        else
        {
            Console.WriteLine("The number is not perfect.");
        }
        
    }
}