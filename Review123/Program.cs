namespace Review123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                //Console.WriteLine("Hello, World!");
                Console.WriteLine("Select opt \n1.Flip Coin Program \n2.Leap Year \n3.Power Of 2 \n4.Reverse Number \n5.Harmonic No \n6.Odd or Even");

                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Review.flipCoin();
                        break;
                    case 2:
                        Review.leapYear();
                        break;
                    case 3:
                        Review.pwrOfTwo();
                        break;
                    case 4:
                        Review.reverseNo();
                        break;
                    case 5:
                        Review.harmonicNo();
                        break;
                    case 6:
                        Review.evenOdd();
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }

        }

        public class Review
        {
            public static void flipCoin()
            {
                Console.WriteLine("How many time to flip coin?");
                int n = Convert.ToInt32(Console.ReadLine()); // n = 10
                int headPercent;
                int headCount = 0, tailCount = 0;

                for (int i = 1; i <= n; i++) // loops 10 times
                {
                    Random random = new Random();
                    double coin = random.NextDouble(); // randoml 0 - 1.0

                    if (coin < 0.5)
                    {
                        Console.WriteLine("Tails");
                        tailCount++;
                    }
                    else
                    {
                        Console.WriteLine("Heads");
                        headCount++;
                    }
                }
                Console.WriteLine();
                headPercent = headCount * 100 / n; 
                Console.WriteLine("Head Percent: " + headPercent);
                Console.WriteLine("Tail Percent: " + (100 - headPercent));
            }

            public static void leapYear()
            {
                Console.WriteLine("Enter Year to check Leap or Not :");
                string str = Console.ReadLine(); //take i/p from user in string str
                int length = str.Length; 

                if (length != 4) 
                {
                    Console.WriteLine("You must enter 4 digit number. Try Again.");
                }
                else
                {
                    int Year = Convert.ToInt32(str);

                    if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                    {
                        Console.WriteLine("{0} is leap year.",+ Year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not leap year.",+ Year);
                    }


                }
            }

            public static void pwrOfTwo()
            {
                int num = 2;
                int power = 1;
                int i = 1;
                Console.WriteLine("Enter the Power: ");
                int p = Convert.ToInt32(Console.ReadLine());

                if (p >= 0 && p < 31)
                {
                    for (i = 1; i <= p; i++)
                    {
                        power = power * num;  //1*2 = 2 , 2*2 =4 , , 4*2 =8
                        Console.WriteLine(power);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter power between 0-31");
                }
            }

            public static void reverseNo()
            {
                int reverse = 0, rem;
                Console.WriteLine("Enter a number to be reversed: ");
                int n = Convert.ToInt32(Console.ReadLine()); // n= 123

                while (n != 0)
                {
                    rem = n % 10; // 123 % 10 = 3 , 
                    reverse = reverse * 10 + rem;  // 0* 10 + 3
                    n = n / 10; // 123 / 10 = 12
                }
                Console.WriteLine("Reversed Number: " + reverse);
            }

            public static void harmonicNo()
            {
                Console.WriteLine("Which Harmonic Number you want: ");
                int n = Convert.ToInt32(Console.ReadLine()); // 3rd no , n = 3

                int i = 1;
                decimal harNo = 0;

                for (i = 1; i <= n; i++)
                {
                    harNo = harNo + (1 / (decimal)i); // 1 + 1/2 + 1/3
                }

                Console.WriteLine("Harmonic Number is " + harNo);
            }

            public static void evenOdd()
            {
                Console.WriteLine("Enter a Number to check odd or even: ");
                int num = Convert.ToInt32(Console.ReadLine()); // num = 13

                if (num % 2 == 0)    // 13 % 2 = 1  fail go to else
                {
                    Console.WriteLine($"{num} is even.");
                }
                else
                {
                    Console.WriteLine($"{num} is odd.");
                }
            }

        }
    }
}