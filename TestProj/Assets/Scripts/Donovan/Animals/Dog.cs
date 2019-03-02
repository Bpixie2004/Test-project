using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private string owner;
    private string name;

    public override void Move()
    {
        base.Move();
        Debug.Log("Dog Move");
    }

}
