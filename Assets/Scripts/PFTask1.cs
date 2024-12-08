using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PFTask1 : MonoBehaviour
{
    public int age = 25;
    public  double price = 9.99;
    public string Myname = "Shaheryar";
    public bool israin = true;
    public char grade = 'A';

    public int num1 = 16;
    public int num2 = 10;

    public int intvalue = 20;
    public double doublevalue = 5.5;

    public double temprature = 30.56;


    public string input = "he was running for 15 minutes";

    public bool haspassed = true;



    public bool itsSunny = true;
    public bool noUmbrella= true;



    void Start()
    {
       
        print(age);
        print(price);
        print(Myname);
        print(israin);
        print(grade);

        print(num1+ num2);
        print(num1- num2);
        print(num1* num2);
        print(num1/ num2);
        print(num1 % num2); 
        print(++num1); 
        print(--num2);

        if (temprature > 0)
        {
            print("it's  Hot");
        }


        print(input.Length);

        if (!haspassed)
        {
            print("You need to study harder");
        }

        print("My name is " + Myname.Substring(6));



         print(intvalue+(int)doublevalue);
         print((double)intvalue* doublevalue);



        if(itsSunny && noUmbrella)
        {

            print("i will go outside");
        }
        else
        {
            print("i will not go outside");

        }
          print(true && true);
          print(true || false); 
          print(!(true && false));
          print((true || false) && true);


    }
     





}
    
   
