using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PFTask4Function : MonoBehaviour
{
    int output;
    string output1 = string.Empty;

    void Start()
    {

        print(output = Addition(9, 8));
        print(output = Subtraction(9, 8));
        print(output = Multiplication(9, 8));
        print(output = Division(9, 8));
        print(output = GreaterNum(9, 8));
         print(output1= Greeting(""));
    }

    int GreaterNum(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else if (num2 > num1)
        {
            return num2;
        }
        else
        {
            return num1;
        }
    }

    int Addition(int num1, int num2)
    {
        return num1 + num2;
    }

    int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }

    int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }

    int Division(int num1, int num2)
    {
        return num1 / num2;
    }
    string Greeting(string greetings)
    {

        string greeting = Greeting("John");

        return greeting;
    }
}
