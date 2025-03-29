
using dotnet;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("hello wrold");
        //program to find to swap the two numbers
        Console.WriteLine("Enter the value of a");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int temp;
        Console.WriteLine("Before Swap\n");
        Console.WriteLine("Value of a :" + num1);
        Console.WriteLine("Value of b :" + num2);
        Console.WriteLine("After Swap\n");
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine(" value of a :" + num1);
        Console.WriteLine(" value of b:" + num2);



        //program to find the largest number among the three number
        Console.WriteLine("Enter the value of a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of c");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {

            if (a > c)
            {
                Console.WriteLine("a is the largest number");
            }
            else
            {
                Console.WriteLine("c is the greatet number");
            }

        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("b is the greatest number");
            }
            else
            {
                Console.WriteLine("c is the greatest number");
            }
        }

        //Program to check where the given number is odd or even
        Console.WriteLine("Enter the number to determine whether it is odd or even");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("given number " + num + " is even number");
        }
        else
        {
            Console.WriteLine("given number  " + num + " is oddd number");
        }


        //program to find the sum of n natural number
        Console.WriteLine("Enter the n natural number");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            sum = sum + n;
            n--;
        }
        n + 1;
        Console.WriteLine("The sum of " + n + " natural number is" + sum);

        //for finding the factorial of a given number
        factorial fact_obj = new factorial();
       int fact = fact_obj.fact(4);
        Console.WriteLine(fact);

        //for finding the sum of arryay
        int[] arr = new int[] {1,2,3};  
        SumOfArray ArrObj = new SumOfArray();
        int total = ArrObj.sum(arr);
        Console.WriteLine( "The sum of all element of array is"+total);

        //for checking the prime number
        PrimeNumber PrimeObj = new PrimeNumber();
        bool isPrime = PrimeObj.prime(3);
        string message = isPrime ? "prime number " : "not a prime number";
        Console.WriteLine(message);
        

        //program to check whether the given year is leap or not.
        Console.WriteLine("Enter year to check leap year.");
        int year = Convert.ToInt32(Console.ReadLine());
        LeapYear yr = new LeapYear();
        if (yr.Leap(year))
        {
            Console.WriteLine("The year " + year + " is leap year\n");
        }
        else
        {
            Console.WriteLine("The year " + year + " is not leap year\n");
        }

        Console.ReadKey();
    }
}