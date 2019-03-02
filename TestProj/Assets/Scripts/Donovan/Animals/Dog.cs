using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Donovan.Animals
{

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
}