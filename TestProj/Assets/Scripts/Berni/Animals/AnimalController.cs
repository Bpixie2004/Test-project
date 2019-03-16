using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jincom.Donovan;

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

            Jincom.Donovan.Animals.Dog mimi = new Donovan.Animals.Dog();

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