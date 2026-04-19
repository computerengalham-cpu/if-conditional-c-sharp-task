namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////q1:
            //    Console.Write("Enter a number (1-7): ");
            //    int day = Convert.ToInt32(Console.ReadLine());

            //    switch (day)
            //    {
            //        case 1: Console.WriteLine("Monday"); break;
            //        case 2: Console.WriteLine("Tuesday"); break;
            //        case 3: Console.WriteLine("Wednesday"); break;
            //        case 4: Console.WriteLine("Thursday"); break;
            //        case 5: Console.WriteLine("Friday"); break;
            //        case 6: Console.WriteLine("Saturday"); break;
            //        case 7: Console.WriteLine("Sunday"); break;
            //        default:
            //            Console.WriteLine("Invalid day number");
            //            break;
            //    }

            //q2:
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{num} x {i} = {num * i}");
            //}

            //q3:
            //Console.Write("Enter a positive number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num <= 0)
            //{
            //    Console.WriteLine("Please enter a positive number");
            //}
            //else
            //{
            //    while (num >= 1)
            //    {
            //        Console.WriteLine(num);
            //        num--;
            //    }
            //    Console.WriteLine("Go!");
            //}

            //q4:
            //Console.Write("Enter month (1-12): ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //if (month < 1 || month > 12)
            //{
            //    Console.WriteLine("Invalid month number");
            //}
            //else
            //{
            //    switch (month)
            //    {
            //        case 12:
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Winter");
            //            break;

            //        case 3:
            //        case 4:
            //        case 5:
            //            Console.WriteLine("Spring");
            //            break;

            //        case 6:
            //        case 7:
            //        case 8:
            //            Console.WriteLine("Summer");
            //            break;

            //        case 9:
            //        case 10:
            //        case 11:
            //            Console.WriteLine("Autumn");
            //            break;
            //    }
            //}

            //q5:
            //Console.Write("Enter N: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int evenSum = 0, oddSum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //        evenSum += i;
            //    else
            //        oddSum += i;
            //}

            //Console.WriteLine("Even Sum = " + evenSum);
            //Console.WriteLine("Odd Sum = " + oddSum);

            //q6:
            //string correctPassword = "1234";
            //int attempts = 0;

            //while (true)
            //{
            //    Console.Write("Enter password: ");
            //    string input = Console.ReadLine();

            //    if (input == correctPassword)
            //    {
            //        Console.WriteLine("Access Granted");
            //        break;
            //    }
            //    else
            //    {
            //        attempts++;

            //        if (attempts == 3)
            //        {
            //            Console.WriteLine("Account Locked");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Wrong password, {3 - attempts} attempts left");
            //        }
            //    }
            //}


            //q7:
            //while (true)
            //{
            //    Console.Write("Enter first number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter operator (+, -, *, /) or 'exit': ");
            //    string op = Console.ReadLine();

            //    if (op == "exit")
            //        break;

            //    switch (op)
            //    {
            //        case "+":
            //            Console.WriteLine("Result = " + (num1 + num2));
            //            break;

            //        case "-":
            //            Console.WriteLine("Result = " + (num1 - num2));
            //            break;

            //        case "*":
            //            Console.WriteLine("Result = " + (num1 * num2));
            //            break;

            //        case "/":
            //            if (num2 != 0)
            //                Console.WriteLine("Result = " + (num1 / num2));
            //            else
            //                Console.WriteLine("Cannot divide by zero");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operator");
            //            break;
            //    }
            //}

            //q8:
            //Console.Write("Enter start: ");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter end: ");
            //int end = Convert.ToInt32(Console.ReadLine());

            //bool found = false;

            //for (int i = start; i <= end; i++)
            //{
            //    if (i <= 1) continue;

            //    bool isPrime = true;

            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine(i);
            //        found = true;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("No prime numbers found");
            //}

            //q9:
            //Console.Write("Enter number of students: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] scores = new int[n];

            //int max = int.MinValue;
            //int min = int.MaxValue;

            //int excellent = 0, veryGood = 0, good = 0, pass = 0, fail = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter score for student {i + 1}: ");
            //    scores[i] = Convert.ToInt32(Console.ReadLine());

            //    int key = scores[i] / 10;

            //    switch (key)
            //    {
            //        case 10:
            //        case 9:
            //            Console.WriteLine("Excellent");
            //            excellent++;
            //            break;

            //        case 8:
            //            Console.WriteLine("Very Good");
            //            veryGood++;
            //            break;

            //        case 7:
            //            Console.WriteLine("Good");
            //            good++;
            //            break;

            //        case 6:
            //            Console.WriteLine("Pass");
            //            pass++;
            //            break;

            //        default:
            //            Console.WriteLine("Fail");
            //            fail++;
            //            break;
            //    }

            //    if (scores[i] > max) max = scores[i];
            //    if (scores[i] < min) min = scores[i];
            //}

            //Console.WriteLine("\n--- Report ---");
            //Console.WriteLine("Excellent: " + excellent);
            //Console.WriteLine("Very Good: " + veryGood);
            //Console.WriteLine("Good: " + good);
            //Console.WriteLine("Pass: " + pass);
            //Console.WriteLine("Fail: " + fail);
            //Console.WriteLine("Highest: " + max);
            //Console.WriteLine("Lowest: " + min);

            //q10:
            int balance = 5000;
            string pin = "9999";
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter PIN: ");
                string input = Console.ReadLine();

                if (input == pin)
                    break;

                attempts++;
            }

            if (attempts == 3)
            {
                Console.WriteLine("Card Blocked");
                return;
            }

            string[] types = new string[100];
            int[] amounts = new int[100];
            int count = 0;

            while (true)
            {
                Console.WriteLine("\n1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                Console.Write("Choose: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Balance: " + balance);
                        break;

                    case 2:
                        Console.Write("Enter deposit amount: ");
                        int dep = Convert.ToInt32(Console.ReadLine());

                        if (dep > 0 && dep <= 10000)
                        {
                            balance += dep;
                            types[count] = "Deposit";
                            amounts[count] = dep;
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount");
                        }
                        break;

                    case 3:
                        Console.Write("Enter withdraw amount: ");
                        int wit = Convert.ToInt32(Console.ReadLine());

                        if (wit > 0 && wit <= balance)
                        {
                            balance -= wit;
                            types[count] = "Withdraw";
                            amounts[count] = wit;
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdraw amount");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n--- Transactions ---");
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(types[i] + ": " + amounts[i]);
                        }
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
