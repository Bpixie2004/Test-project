using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Berni.Tuts
{

    public class Functions : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //MakeCoffee(0.5f, 3, "Pink");
            //MakeCoffee(0f, 2, "Blue");
            //MakeCoffee(3.2f, 0, "Green");
            // Statement();

            //string S = Statement();
            //Debug.Log(S);
            //string Sum = SumOf("hello", "world");
            //string sum2 = SumOf("more", "Text");

            //string sum3 = SumOf(Sum, sum2);
            //Debug.Log(sum3);

            //int Multiply = Multiplied(7,8);
            //Debug.Log(Multiply);

            bool Function = IsAboveTen(6);
            Debug.Log(Function);
        }

        private bool IsAboveTen(int x)
        {
            return (x > 10);
        }
        //private int Multiplied(int v1, int v2)
        //{
        //    return (v1 * v2);
        //}


        //private string SumOf(string input1, string input2)
        //{
        //    return (input1 +" "+ input2);
        //}


        //private void MyFunction(string someText, int someNumber)
        //{
        //    Debug.Log(someText);
        //    Debug.Log(someNumber);
        //}

        private void MakeCoffee(float milk, int sugar, string Cupcolour)
        {

            Debug.Log(milk);
            Debug.Log(3);
            Debug.Log(Cupcolour);

        }

        //private string Statement()
        //{
        //    Debug.Log("In the function");
        //    return "This is my return text";
        //}
    }
}