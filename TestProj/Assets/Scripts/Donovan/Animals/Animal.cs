using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Donovan.Animals
{

    public class Animal
    {
        private string _type;
        private string _color;
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    Debug.LogError("Age cannot be less than 0 ");
                }
                else
                {
                    _age = value;
                }
            }
        }
        private int numberOfLegs;
        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set
            {
                if (value < 0)
                {
                    Debug.LogError("Legs must be above 0");
                }
                else
                {
                    numberOfLegs = value;
                }

            }


        }


        public virtual void Move()
        {
            Debug.Log("Animal Move");
        }

        public void Eat()
        {
            Debug.Log("Eat");

        }


    }

}