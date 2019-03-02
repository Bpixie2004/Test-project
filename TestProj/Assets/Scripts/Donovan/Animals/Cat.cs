using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private string owner;
    private string name;

    public override void Move()
    {
        base.Move();
        Debug.Log("Cat Move");
    }


}

