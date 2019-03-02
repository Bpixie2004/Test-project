using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Animal dog = new Animal();
        //dog.Move();
        //Animal cat = new Animal();
        //cat.Move();
        //dog.Age = 2;
        //Debug.Log(dog.Age);

        //dog.NumberOfLegs = 4;
        //Debug.Log(dog.NumberOfLegs);
        //Dog Spot = new Dog();
        //Spot.Move();

        //Cat Meow = new Cat();
        //Meow.Move();

        Animal[] animals = new Animal[2];

        animals[0] = new Dog();
        animals[1] = new Cat();

        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].Move();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
