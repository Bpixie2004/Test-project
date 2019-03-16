using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Berni.Animals
{

    public class Dog : Animal
    {
        private Dictionary<string, WalkLog> walkRating = new Dictionary<string, WalkLog>();

        private string owner;
        private string name;

        private List<string> friends = new List<string>();

        public struct WalkLog
        {
            public float MinutesWalked;
            public int BallsThrown;
            public string Weather;
            public bool SawSquirrel;

            public WalkLog(float minsWalked, int balls, string weather, bool sawSquirrel)
            {
                this.MinutesWalked = minsWalked;
                this.BallsThrown = balls;
                this.Weather = weather;
                this.SawSquirrel = sawSquirrel;
                Debug.Log("We walked " + minsWalked + "but we did throw " + balls);
            }
        }

        private WalkLog _walklog = new WalkLog(20f, 10, "Sunny", true);
        

        protected override void Move()
        {
            //base.Move();
            //Debug.Log("dog Move");
            switch (_animalMoveState)
            {
                case AnimalMoveState.Walking:
                    Debug.Log("Dog is walking");
                    break;

                case AnimalMoveState.Running:
                    Debug.Log("Dog is running");
                    break;

                case AnimalMoveState.Sitting:
                    Debug.Log("Dog is sitting");
                    break;
            }
        }

        public void Sit()
        {
            _animalMoveState = AnimalMoveState.Sitting;
            Move();
        }

        public void Run()
        {
            _animalMoveState = AnimalMoveState.Running;
            Move();
        }
        public void Walk()
        {
            _animalMoveState = AnimalMoveState.Walking;
            Move();
        }

        public void AddFriend(string friendsName)
        {
            if (friends.Contains(friendsName) == false)
            {
                friends.Add(friendsName);
                Debug.Log("Added new friend " + friendsName);
            }

            else
            {
                Debug.LogError(friendsName + " is already a friend.");
            }

        }

        public int HowMany()
        {
            return friends.Count;
        }

        public void Dogwalking(string walkerName, int Rating)
        {

            if (walkRating.ContainsKey(walkerName))
            {
                walkRating[walkerName] = Rating;
                Debug.Log(walkerName + " has a new rating of " + Rating);
            }

            else
            {
                walkRating.Add(walkerName, Rating);
                Debug.Log(walkerName + " is new and have a new rating of " + Rating);
            }
        }
    }
}