using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Donovan.Tutorial
{

    public class Dummy : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            //string hungry = "lunch Please";
            //int cup = 5;
            //float frac = 4.5f;
            //bool mine = true;

            //cup = 7;
            //cup = cup + 1;
            //cup++;

            //string[] newArray = new string[] { "cup", "mug", "glass", "saucer", "pen" };
            //for (int i = 0; i < newarray.length; i++)
            //{
            //    Debug.log(newarray[i]);
            //}
            //foreach (string item in newArray)
            //{
            //    Debug.Log(item);
            //}
            //int count = -1;
            //    while (count < 10)
            //{
            //    count++;
            //    Debug.Log(count);
            //}

            //bool result = true;
            //if (result == true)
            //{
            //    Debug.Log("The Result is True");

            //}
            //else
            //{
            //    Debug.Log("The Result is False");
            //}

            //int count = 15;
            //if (count > 10)
            //{
            //    Debug.Log("count is greater than 10");
            //}
            //else if (count < 10)
            //{
            //    Debug.Log("count is less than 10");
            //}
            //else if (count == 10)
            //{
            //    Debug.Log("count is equal to 10");
            //}
            //else
            //{
            //    Debug.Log(count + "is not a number");
            //}

            int value = 6;
            switch (value)
            {
                case 1:
                    Debug.Log("Show Side 1");
                    break;

                case 2:
                    Debug.Log("Show Side 2");
                    break;

                case 3:
                    Debug.Log("Show Side 3");
                    break;

                case 4:
                    Debug.Log("Show Side 4");
                    break;
                case 5:
                    Debug.Log("Show Side 5");
                    break;

                case 6:
                    Debug.Log("Show Side 6");
                    break;

                default:
                    Debug.Log("value is no idea");
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