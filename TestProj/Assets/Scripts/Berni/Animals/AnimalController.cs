using System.Collections;
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

            string otherDogName = "Scruffy";

            Dog Spot = new Dog();
            //Spot.Move();


            //Spot.friends.Add(otherDogName);
            //Spot.friends.Add("Muffin");
            //Spot.friends.Insert(0, "Poodle");
            //Spot.friends.Remove(otherDogName);
            //Spot.friends.RemoveAt(0);
            ////Spot.friends.Clear();



            //if(Spot.friends.Contains("Muffin"))
            //{

            //    Debug.Log("We know a Muffin");
            //}

            //for (int i = 0; i < Spot.friends.Count; i++)
            //{
            //    Debug.Log(Spot.friends[i]);
            //}

            Spot.AddFriend("Something");
            Spot.AddFriend("Something");
            Spot.AddFriend("Catnip");
            Spot.Dogwalking("Parker", 5);
            Spot.Dogwalking("Sue", 7);
            Spot.Dogwalking("Sue", 3);


            Debug.Log (Spot.HowMany());


            //Spot.Run();
            Spot.Sit();

            if (Spot.MoveState == Animal.AnimalMoveState.Sitting)
            {
                Spot.Run();
            }

            //Cat Ginger = new Cat();
            //Ginger.Move();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}