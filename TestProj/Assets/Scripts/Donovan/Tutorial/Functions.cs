using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Donovan.Tutorial
{

    public class Functions : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //MyFunction("This is the text", 12);
            //MyFunction("New Text", 18);
            //MakeCoffee("Bernie", 3, 0.3f);
            //MakeCoffee("Jeff", 0, 0.2f);
            //MakeCoffee("Donovan", 0, 0.0f);
            //string s = MyFunction(); 
            //Debug.Log(s);
            //string s = MyCalc("Add this ", "To This");
            //Debug.Log(s);
            int g = MyMult(6, 9);
            Debug.Log(g);

            bool f = IsAboveTen(7);
            Debug.Log(f);
        }


        //private void MyFunction(string someText, int someNumber)
        //{

        //    Debug.Log(someNumber);
        //    Debug.Log(someText);
        //}

        //private void MakeCoffee (string Person, int Sugar, float SomeMilk)
        //{

        //    Debug.Log(Person);
        //    Debug.Log(Sugar);
        //    Debug.Log(SomeMilk);
        //}

        //private string MyFunction()
        //{
        //    return "This is my return text";
        //}


        private string MyCalc(string TextOne, string TextTwo)
        {
            return TextOne + TextTwo;

        }

        private int MyMult(int x, int y)
        {
            return x * y;

        }

        private bool IsAboveTen(int x)
        {
            return x > 10;
        }

    }
}