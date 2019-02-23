using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        string hungry = "lunch Please";
        int cup = 5;
        float frac = 4.5f;
        bool mine = true;

        cup = 7;
        cup = cup + 1;
        cup++;

        string[] newArray = new string[] { "cup", "mug", "glass", "saucer", "pen" };
        //for (int i = 0; i < newarray.length; i++)
        //{
        //    Debug.log(newarray[i]);
        //}
        //foreach (string item in newArray)
        //{
        //    Debug.Log(item);
        //}
        int count = -1;
            while (count < 10)
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
