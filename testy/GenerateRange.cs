using System;

namespace testy;
    public class Generate
    {
        public static void Gener()
        {
            
                Console.WriteLine("enter lower bound integer: ");
                int minimum = int.Parse(Console.ReadLine());

                Console.WriteLine("enter max value");
                int maximum = int.Parse(Console.ReadLine());


                for (int number = minimum; number < maximum - 1; number++)
                {
                    int sum = 0;
                    for (int n = 1; n < number - 1; n++)
                    {
                        if (number % n == 0)
                        {
                            sum += n;
                        }
                    }
                    if (sum == number)
                    {
                        Console.WriteLine($"number {number} is perfect.");
                        Console.WriteLine("Return to exit.");
                
                
                    }
                }

            }

        }
    


