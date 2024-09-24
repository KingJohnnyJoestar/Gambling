namespace Gambling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play The Game 21");
            //Console.WriteLine("Do you wanna play");
            //string svar1 = Console.ReadLine();

            //if (svar1 == "play")
            //{
            //    Random rand = new Random();
            //    int randomNumber1 = rand.Next(1, 7);
            //    Console.WriteLine("You Got A " + randomNumber1  + " That Means That You Gotten " + randomNumber1 + " Point");

            //    Console.WriteLine("");

            //    Random rando = new Random();
            //    int randomNumber2 = rand.Next(1, 7);
            //    Console.WriteLine("The Computer Plays And Gets " + randomNumber2 + " That Means The Computer Has " + randomNumber2 + " Point");

            //}
            int sum1 = 0;
            int sum2 = 0;

            Console.WriteLine("Hejhej");

            while (true)
            {
                Console.WriteLine("");

                if (sum2 > 21)
                {
                    Console.WriteLine("Dealer is dead, Bastard!!!");
                    break;
                }
                else if (sum1 > 21)
                {
                    Console.WriteLine("You Have More Then 21 And You Are Busted!, Bastard!!!");
                    break;
                }

                Console.WriteLine("play or stay");
                string svar2 = Console.ReadLine();

                Random rand = new Random();
                int randomNumber1 = rand.Next(1, 9);
                int randomNumber2 = rand.Next(1, 7);

                if (svar2 == "play")
                {
                    sum1 = randomNumber1 + sum1;
                    Console.WriteLine("You Got A " + randomNumber1 + " That Means That You Gotten " + sum1 + " Point");

                    Console.WriteLine("");

                    sum2 = randomNumber2 + sum2;
                    Console.WriteLine("The Computer Plays And Gets " + randomNumber2 + " That Means The Computer Has " + sum2 + " Point");
                }
                else if (svar2 == "stay")
                {
                    Console.WriteLine("You Stay And You Have " + sum1 + " Point");
                    Console.WriteLine("");
                    Console.WriteLine("The Computer Has " + sum2 + " Point");

                    Console.WriteLine("");

                    if (sum1 <= 21 && sum1 > sum2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Congratulation You are the winner");

                    }
                    else if (sum1 > 21 || (sum2 >= sum1 && sum2 <= 21))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Sorry You Have To Much, Better Luck Next Time");
                    }
                    else if (sum1 <= 21 && sum2 > 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Congratulation You are the winner");
                    }
                    else if (sum2 <= 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Congratulation The Computer Wins");
                    }

                    break;






                }}}}}

