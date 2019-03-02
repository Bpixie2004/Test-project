
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Berni.Tuts
{

    public class Dummy : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            string MyString = "Air Bunnies";
            int WholeNumber = 100;
            float Decimal = 0.45f;
            bool On = false;

            WholeNumber = 200;
            WholeNumber = WholeNumber + 1;
            WholeNumber++;

            string[] newArray = new string[] { "Jump", "Sit", "Run", "Roll", "Climb" };

            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Debug.Log(newArray[i]);
            //}

            //foreach (string item in newArray) //for every string in this array
            //{
            //    Debug.Log(item);

            //}

            //int count = -1;
            //    while(count < 10)
            //{

            //    count++;
            //    Debug.Log(count);

            //}

            //bool result = true;
            //if (result == true)
            //{
            //    Debug.Log("The result is true");
            //}

            //else
            //{
            //    Debug.Log("The result is false");
            //}

            //int count = 9;
            //if (count > 10)
            //{
            //    Debug.Log("Greater than 10");
            //}
            //else if (count < 10)
            //else if (count < 10)
            //{
            //    Debug.Log("less than 10");
            //    Debug.Log("less than 10");
            //}
            //else if (count == 10)
            //{
            //    Debug.Log("Equal to 10");
            //}
            //else
            //{
            //    Debug.Log(count+ "Is not a number");
            //}

            int diceNumber = 4;

            switch (diceNumber)
            {
                case 1:
                    Debug.Log("Show side 1");
                    break;
                case 2:
                    Debug.Log("Show side 2");
                    break;
                case 3:
                    Debug.Log("Show side 3");
                    break;
                case 4:
                    Debug.Log("Show side 4");
                    break;
                case 5:
                    Debug.Log("Show side 5");
                    break;
                case 6:
                    Debug.Log("Show side 6");
                    break;
                default:
                    Debug.Log("Its another number");
                    break;
            }


        }

        //I prefer if you did xyz

        // Update is called once per frame
        void Update()
        {

        }
    }
}