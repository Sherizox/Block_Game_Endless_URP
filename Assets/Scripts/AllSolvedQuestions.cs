//using System;
//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;

//public class AllSolvedQuestions : MonoBehaviour
//{
//    public int age = 25;
//    public double price = 9.99;
//    public string Myname = "Shaheryar";
//    public bool israin = true;
//    public char grade = 'A';

//    public int num1 = 16;
//    public int num2 = 10;

//    public int intvalue = 20;
//    public double doublevalue = 5.5;

//    public double temprature = 30.56;


//    public string input = "he was running for 15 minutes";

//    public bool haspassed = true;



//    public bool itsSunny = true;
//    public bool noUmbrella = true;


//    int digit = 20;

//    int a, e, i, o, u;
//    int userinput;

//    int num4;
//    int num5;
//    int num6;

  

//    int output;
//    string output1 = string.Empty;


//    void Start()
//    {
//        //functions

//        print(output = Addition(9, 8));
//        print(output = Subtraction(9, 8));
//        print(output = Multiplication(9, 8));
//        print(output = Division(9, 8));
//        print(output = GreaterNum(9, 8));
//        print(output1 = Greeting(""));



//        print(age);
//        print(price);
//        print(Myname);
//        print(israin);
//        print(grade);

//        print(num1 + num2);
//        print(num1 - num2);
//        print(num1 * num2);
//        print(num1 / num2);
//        print(num1 % num2);
//        print(++num1);
//        print(--num2);

//        if (temprature > 0)
//        {
//            print("it's  Hot");
//        }


//        print(input.Length);

//        if (!haspassed)
//        {
//            print("You need to study harder");
//        }

//        print("My name is " + Myname.Substring(6));



//        print(intvalue + (int)doublevalue);
//        print((double)intvalue * doublevalue);



//        if (itsSunny && noUmbrella)
//        {

//            print("i will go outside");
//        }
//        else
//        {
//            print("i will not go outside");

//        }
//        print(true && true);
//        print(true || false);
//        print(!(true && false));
//        print((true || false) && true);






//        //// Loops 

//        for (int i = 0; i <= 100; i++)
//        {
//            if (i % 2 == 0)
//                print("print " + i);

//        }


//        int num1 = 1;
//        int i = 0;
//        while (i <= 10)
//        {

//            print("Answer" + num1 * i);

//            i++;
//        }

//        int j = 1;
//        do
//        {
//            num1 = num1 * 1;
//            j++;
//        } while (i <= num1);


//        string hello = "hello";
//        for (int i = hello.Length - 1; i >= 0; i--)
//        {
//            print($"{hello[i]}");
//            print("hello in reverse: ");
//        }


//        int sum = 0;
//        for (int num = 1; num <= 10; num += 2)
//        {
//            sum += num;
//        }





//        for (int i = 1; i <= 10; i++)
//        {
//            if (10 % i == 0)
//            {
//                print(i + " ");
//            }
//        }

//        bool isPrime = true;
//        for (int i = 2; i < 7; i++)
//        {
//            if (7 % i == 0)
//            {
//                isPrime = false;
//                break;
//                print(i + " ");
//            }
//        }


//        for (int i = 1; i <= 5; i++)
//        {
//            for (int j = 1; j <= i; j++)
//            {
//                print("*");
//            }
//            print();
//        }

//        for (int i = 1; i <= 5; i++)
//        {
//            for (int j = i; j <= 5; j++)
//            {
//                print("*");
//            }
//            print();
//        }

//        for (int i = 1; i <= intvalue; i++)
//        {
//            if (intvalue % i == 0)
//            {
//                print(i);
//            }
//        }
//        //invert
//        for (int i = 1; i <= 5; i++)
//        {
//            for (int k = 5 - i; k > 0; k--)
//            {
//                print(" ");
//            }
//            for (int j = 1; j <= i; j++)
//            {
//                print("*");
//            }
//            print();
//        }


//        /// if Conditions 

//        if (digit > 0)
//        {
//            print("number is positive");
//        }
//        else if (digit < 0)
//        {
//            print("number is negative");
//        }


//        if (digit % 2 == 0)
//        {
//            print("the number is even");


//        }
//        else if (digit % 2 == 1)
//        {
//            print("the number is odd");
//        }

//        if (userinput == a || userinput == e || userinput == i || userinput == o || userinput == u)
//        {
//            print(" the word is vowel");

//        }
//        else
//        {
//            print("the word is not vowel");
//        }



//        if (userinput >= 18)
//        {
//            print("user is eligible to vote");
//        }
//        else
//        if (userinput <= 18)
//        {

//            print("user is not eligible to vote");
//        }


//        if (num4 > num5 && num4 > num3)
//        {
//            print(num4 + "is greater");

//        }
//        else if (num5 > num4 && num5 > num3)
//        {
//            print(num5 + "is greater");

//        }
//        else if (num3 > num5 && num3 > num4)
//        {
//            print(num3 + "is greater");

//        }
//        else if (num4 == num5 && num3 == num4 && num5 == num3)
//        {
//            print(" number are equal");
//        }
//        else if (num4 == num5)
//        {
//            print(num3 + " other numbers are equal");
//        }

//        else if (num4 == num3)
//        {
//            print(num5 + " other numbers are equal");
//        }
//        else if (num3 == num5)
//        {
//            print(num4 + " other numbers are equal");
//        }





//        if (userinput > 90 && userinput < 100)
//        {
//            print("A");
//        }
//        if (userinput > 80 && userinput < 89)
//        {
//            print("B");
//        }
//        if (userinput > 70 && userinput < 79)
//        {
//            print("C");
//        }
//        if (userinput > 60 && userinput < 69)
//        {
//            print("D");
//        }
//        if (userinput > 0 && userinput < 59)
//        {
//            print("F");
//        }







//        if (month == 2)
//        {

//            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
//            {
//                days = 29;
//            }
//            else
//            {
//                days = 28;
//            }
//        }
//        else if (month == 4 || month == 6 || month == 9 || month == 11)
//        {
//            days = 30;
//        }
//        else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
//        {
//            days = 31;
//        }
//        else
//        {
//            print("Invalid month entered.");

//        }

//        print($"Number of days in {month}/{year}: {days}");


      
//        Console.Write("Enter temperature in Celsius: ");
//        double celsius = Convert.ToDouble(Console.ReadLine());

//        double fahrenheit = (celsius * 9 / 5) + 32;
//        Console.WriteLine($"The temperature in Fahrenheit is {fahrenheit}.");
//    }

//    int GreaterNum(int num1, int num2)
//    {
//        if (num1 > num2)
//        {
//            return num1;

//        }
//        else if (num2 > num1)
//        {
//            return num2;
//        }
//        else
//        {
//            return num1;
//        }

//    }
//    int Addition(int num1, int num2)
//    {
//        return (num1 + num2);

//    }
//    int Subtraction(int num1, int num2)
//    {
//        return (num1 - num2);

//    }
//    int Multiplication(int num1, int num2)
//    {
//        return (num1 * num2);

//    }
//    int Division(int num1, int num2)
//    {
//        return (num1 / num2);

//    }
//    string Greeting(string greetings)
//    {

//        string greeting = Greeting("John");

//        return greeting;
//    }









//}









