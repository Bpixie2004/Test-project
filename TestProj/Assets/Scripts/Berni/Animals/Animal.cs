using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Berni.Animals
{

    public class Animal
    {
        protected string _type;
        protected string _color;
        protected int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    Debug.LogError("Age cannot be less than 0");
                }
                else
                {
                    _age = value;
                }
            }
        }

        private int numberOfLegs;
        public int Legs
        {
            get { return numberOfLegs; }
            set
            {
                if (value < 0)
                {
                    Debug.LogError("Legs cannot be less than 0");
                }
                else
                {
                    numberOfLegs = value;
                }
            }
        }

        public enum AnimalMoveState
        {
            Walking,
            Running,
            Sitting
        }

        protected AnimalMoveState _animalMoveState = AnimalMoveState.Running;

        public AnimalMoveState MoveState
        {
            get { return _animalMoveState; }
        }

        protected virtual void Move()
        {

            Debug.Log("Animal Move");
        }

        public void Eat()
        {
            Debug.Log("Eat");
        }
    }

}