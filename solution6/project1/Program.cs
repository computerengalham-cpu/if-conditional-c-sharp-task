namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for
             //for (int x = 0; x < 5; x++) {
            //    Console.WriteLine("my age is 24");
            //}

            //q2:
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int x = 1; x <= 5; x++)
            //    {
            //        Console.WriteLine((i, x));
            //    }
            //    Console.WriteLine();
            //}

            //q3:
            //Console.WriteLine("please enter number");
            //int x = Convert.ToInt32(Console.ReadLine());
            //bool prime = true;

            //for(int i = 2; i < x; i++) { 
            //if (x%i == 0)
            //{
            //        prime = false;
            //        break;
            //}}
            //if (prime)
            //{
            //    Console.WriteLine("prime number");
            //}
            //else
            //{
            //    Console.WriteLine("not prime number");
            //}


            //easytask1:
            //Console.WriteLine("please enter a number from 1 to 7");
            //int x = Convert.ToInt32(Console.ReadLine());
            //switch (x)
            //{
            //    case 1:Console.WriteLine("Monday");break;
            //    case 2: Console.WriteLine("Tuesday");break;
            //    case 3: Console.WriteLine("Wedensday"); break;
            //    case 4: Console.WriteLine("Thursday"); break;
            //    case 5: Console.WriteLine("Friday"); break;
            //    case 6: Console.WriteLine("Saturday"); break;
            //    case 7: Console.WriteLine("Sunday"); break;
            //    default: Console.WriteLine("Invalid day number");break;
            //}

            //easytask2:
            //Console.WriteLine("please enter a number");
            //int x = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1;i<=10;i++)
            //{
            //    Console.WriteLine(x+"x"+i+"="+(x*i));
            //}
            #endregion
            
            #region while
            //Q1:
            //Console.WriteLine("please enter number:");
            //Random rnd = new Random();
            //int randomInt = rnd.Next(0, 5);
            //int num = Convert.ToInt32(Console.ReadLine());
            //while (num != randomInt)
            //{

            //        Console.WriteLine("not correct number, please enter number again:");
            //        num = Convert.ToInt32(Console.ReadLine());

            //}

            //q2:
            //Console.WriteLine("please enter number:");
            //Random rnd = new Random();
            //int randomInt = rnd.Next(0, 5);
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //while (num != randomInt)
            //{
            //    i++;
            //    if (i < 3)
            //    {
            //        Console.WriteLine("not correct number, please enter number again:");
            //        num = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("you used all 3 tries");
            //        break;
            //    }
            //}

            #endregion

            #region string
            Console.WriteLine("enter word:");
            string word = Console.ReadLine();

            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            if (word == reversed)
            {
                Console.WriteLine("Perfect");
            }
            else
            {
                Console.WriteLine("Not Perfect");
            }
            #endregion
        }
    }
}
