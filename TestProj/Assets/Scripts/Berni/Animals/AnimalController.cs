﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Berni.Animals
{

    public class AnimalController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //Animal dog = new Animal();
            //dog.Move();

            //Animal cat = new Animal();
            //cat.Move();

            //dog.Age = 5;
            //Debug.Log(dog.Age);

            //dog.Legs = 4;
            //Debug.Log(dog.Legs);

            Dog Spot = new Dog();
            Spot.Move();

            Cat Ginger = new Cat();
            Ginger.Move();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}