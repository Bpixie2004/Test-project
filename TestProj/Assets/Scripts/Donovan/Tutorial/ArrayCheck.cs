using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayCheck : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        int[] newArray = new int[] { 6, 7, 32, 58 };
        int x = 0;



        for (int i = 0; i < newArray.Length; i++)
        {
           x = x + newArray[i];
            
        }
        if (x > 200) 
        {
            Debug.Log("This number is above 200");
        }
        else if (x < 200)
        {
            Debug.Log("This number is less than 200");
        }
        else
        {
            Debug.Log("this is equal to 200");
        }

        Debug.Log(x);



    }

    // Update is called once per frame
    void Update()
    {

    }
}
