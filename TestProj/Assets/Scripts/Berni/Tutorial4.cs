using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Jincom.Berni.Tuts
{


    public class Tutorial4 : MonoBehaviour
    {
        Dictionary<int, string> _myDictionary = new Dictionary <int, string>();

        //enum AnimalMoveState
        //{
        //    Walking,
        //    Running,
        //    Sitting
        //}

        //private AnimalMoveState _animalMoveState = AnimalMoveState.Running;

        // Start is called before the first frame update
        void Start()
        {
            //if(_animalMoveState == AnimalMoveState.Sitting)
            //{
            //    Debug.Log("Its sitting");
            //}

            //else if(_animalMoveState == AnimalMoveState.Running)
            //{
            //    Debug.Log("Its running");
            //}

            _myDictionary.Add(5, "my string");
            _myDictionary[5] = "Oh no!";

            //_myDictionary.Remove(5);

            if (_myDictionary.ContainsKey(5))
            {
                Debug.Log("Entry exists");
            }

            foreach (int key in _myDictionary.Keys)
            {
                Debug.Log(key);
                Debug.Log(_myDictionary[key]);
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}