
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        string MyString = "Air Bunnies";
        int WholeNumber = 100;
        float Decimal = 0.45f;
        bool On = false;

        WholeNumber = 200;
        WholeNumber = WholeNumber + 1;
        WholeNumber ++;

       string[] newArray = new string[] {"Jump", "Sit", "Run", "Roll", "Climb" };

        //for (int i = 0; i < newArray.Length; i++)
        //{
        //    Debug.Log(newArray[i]);
        //}

        //foreach (string item in newArray) //for every string in this array
        //{
        //    Debug.Log(item);

        //}

        int count = -1;
            while(count < 10)
        {
            
            count++;
            Debug.Log(count);

        }


    }
	
    //I prefer if you did xyz

	// Update is called once per frame
	void Update ()
    {
		
	}
}
