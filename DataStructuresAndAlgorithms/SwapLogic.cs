﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class SwapLogic
    {
        //http://javarevisited.blogspot.com/2013/02/swap-two-numbers-without-third-temp-variable-java-program-example-tutorial.html
        public SwapLogic()
        {
            int a = 12;
            int b = 38;
            SwapByAddition(ref a, ref b);
            SwapByDivision(ref a, ref b);
            SwapByXOR(ref a, ref b);
        }

        private void SwapByAddition(ref int a, ref int b)
        {
            Console.WriteLine("value of a and b before swapping, a: " + a + " b: " + b);
            //swapping value of two numbers without using temp variable
            a = a + b; //now a is 30 and b is 20
            b = a - b; //now a is 30 but b is 10 (original value of a)
            a = a - b; //now a is 20 and b is 10, numbers are swapped
            Console.WriteLine("value of a and b after swapping, a: " + a + " b: " + b);
        }

        private void SwapByDivision(ref int a, ref int b)
        {
            Console.WriteLine("value of a and b before swapping, a: " + a + " b: " + b);
            //swapping value of two numbers without using temp variable using multiplication and division
            a = a * b; //now a is 18 and b is 3
            b = a / b; //now a is 18 but b is 6 (original value of a)
            a = a / b; //now a is 3 and b is 6, numbers are swapped
            Console.WriteLine("value of a and b after swapping using multiplication and division, a: " + a + " b: " + b);
        }

        private void SwapByXOR(ref int a, ref int b)
        {
            /*
            A       B       A ^ B(A XOR B)
            0       0       0(zero because operands are same)
            0       1       1
            1       0       1(one because operands are different)
            1       1       0
            */
            Console.WriteLine("value of a and b before swapping, a: " + a + " b: " + b);
            //swapping value of two numbers without using temp variable and XOR bitwise operator     
            a = a ^ b; //now a is 6 and b is 4
            b = a ^ b; //now a is 6 but b is 2 (original value of a)
            a = a ^ b; //now a is 4 and b is 2, numbers are swapped
            Console.WriteLine("value of a and b after swapping using XOR bitwise operation, a: " + a + " b: " + b);
        }



    }
}
