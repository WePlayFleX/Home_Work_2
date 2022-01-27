using System;
using cs = System.Console;
using cv = System.Convert;

namespace Home_Work_2
{
    class Home_Work_2
    {
        public static void Main(string[] args)
        {
            //Task_1
            Random rnd = new Random();
            int a = rnd.Next(-10, 10);
            int b = rnd.Next(-10, 10);
            int c = rnd.Next(-10, 10);

            string msg = string.Empty;

            cs.WriteLine("Task_1");
            cs.WriteLine("A: " + a);
            cs.WriteLine("B: " + b);
            cs.WriteLine("C: " + c);

            bool result = Pos_or_Neg.CheckNumber(a, b, c);
            msg = result ? "Positive! " : "Negative( ";
      
            cs.WriteLine(msg);

            //Task_2
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            c = rnd.Next(1, 10);

            cs.WriteLine("Task_2");
            cs.WriteLine("A: " + a);
            cs.WriteLine("B: " + b);
            cs.WriteLine("C: " + c);

            result = Parity.CheckAllEvenNumber(a, b, c);
            msg = result ? "Even! " : "Odd( ";

            cs.WriteLine(msg);

            //Task3
            cs.WriteLine("Task_3");
            cs.WriteLine("Enter a four-digit number: ");
            int num = cv.ToInt32(cs.ReadLine());

            result = Subsequence.CheckSubsequence(num);
            msg = result ? "This is an ascending sequence! " : "Nope( ";

            cs.WriteLine(msg);

            //Task4
            string number = string.Empty;
            cs.WriteLine("Task_4");
            cs.WriteLine("Enter a four-digit number: ");
            number = cv.ToString(cs.ReadLine());

            result = Palindrome.CheckPalindrome(number);
            msg = result ? "This is a palindrome! " : "Nope( ";

            cs.WriteLine(msg);

            //Task_5
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            c = rnd.Next(1, 10);

            cs.WriteLine("Task_5");
            cs.WriteLine("A: " + a);
            cs.WriteLine("B: " + b);
            cs.WriteLine("C: " + c);

            result = Triangle.CheckTriangle(a, b, c);
            msg = result ? "This is a triangle! " : "Nope( ";

            cs.WriteLine(msg);


            cs.ReadKey();
        }
    }
}
