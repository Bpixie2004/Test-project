using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Berni.Animals
{

    public class Cat : Animal
    {
        public override void Move()
        {
            base.Move();
            Debug.Log("Cat Move");
        }
    }
}