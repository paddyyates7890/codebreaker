using System;

namespace codebreakerchallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[] code1 = new int[6];
            int[] usrnum1 = new int[6];
            int count = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;


            Console.WriteLine("welcome to my code breaker i bet you can't crack my code 4 didget code you have 12 guesses");


            for (int i = 0; i < 4; i++)
            {
                code1[i] = rnd.Next(0, 9);
            }

           

            while (count3 != 13)
            {
                count2 = 0;
                count4 = 0;

                Console.WriteLine("enter your guess number by number");
                usrnum1[1] = int.Parse(Console.ReadLine());
                usrnum1[2] = int.Parse(Console.ReadLine());
                usrnum1[3] = int.Parse(Console.ReadLine());
                usrnum1[4] = int.Parse(Console.ReadLine());

                for (int i = 0; i < 4; i++)
                {
                    if (code1[i] == usrnum1[i])
                    {
                        count = count + 1;

                    }

                }


                System.Threading.Thread.Sleep(1000);

                if (code1[1] == usrnum1[1])
                {
                    Console.WriteLine("your first number is correct");
                    count4 = count4 + 1;
                }
                else
                {
                    Console.WriteLine("your first number is incorrect");
                }

                System.Threading.Thread.Sleep(1000);

                if (code1[2] == usrnum1[2])
                {
                    Console.WriteLine("your second number is correct");
                    count4 = count4 + 1;
                }
                else
                {
                    Console.WriteLine("your second number is incorrect");
                }

                System.Threading.Thread.Sleep(1000);

                if (code1[3] == usrnum1[3])
                {
                    Console.WriteLine("your third number is correct");
                    count4 = count4 + 1;

                }
                else
                {
                    Console.WriteLine("your third number is incorrect");
                }

                System.Threading.Thread.Sleep(1000);

                if (code1[4] == usrnum1[4])
                {
                    Console.WriteLine("your fourth number is correct");
                    count4 = count4 + 1;
                }
                else
                {
                    Console.WriteLine("your fourth number is incorrect");
                }

                System.Threading.Thread.Sleep(1000);

                if (count4 == 4)
                {
                    winner();
                }

                if (code1[1] == usrnum1[2] || code1[1] == usrnum1[3] || code1[1] == usrnum1[4])
                {
                    count2 = count2 + 1;
                }


                if (code1[2] == usrnum1[1] || code1[2] == usrnum1[3] || code1[2] == usrnum1[4])
                {
                    count2 = count2 + 1;
                }

                if (code1[3] == usrnum1[2] || code1[3] == usrnum1[1] || code1[3] == usrnum1[4])
                {
                    count2 = count2 + 1;
                }

                if (code1[4] == usrnum1[2] || code1[4] == usrnum1[3] || code1[4] == usrnum1[1])
                {
                    count2 = count2 + 1;
                }

                Console.WriteLine("you have " + count2 + " numbers correct in the wrong place press enter for your next guess");

                Console.WriteLine(count3 + " guesses used");

                Console.ReadLine();

                Console.Clear();



                count3 = count3 + 1;
            }

        }
        public static void winner()
        {
            Console.WriteLine("well done you have beeten my code breaker ");
            System.Threading.Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("ending");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("ending");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("ending");
            System.Threading.Thread.Sleep(1000);

            Environment.Exit(0);
        }
        

        
      
    }
}
