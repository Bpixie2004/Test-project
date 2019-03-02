using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Berni.Tuts
{

    public class Excercise : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int[] newArray = new int[] { 1, 2, 3, 5, 6 };
            int SumOfArray = 0;

            foreach (int item in newArray)
            {
                SumOfArray = SumOfArray + item;
            }
            Debug.Log(SumOfArray);


            if (SumOfArray < 10)
            {
                Debug.Log("Below 10");
            }
            else if (SumOfArray >= 10)
            {
                Debug.Log("Above 10");
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}