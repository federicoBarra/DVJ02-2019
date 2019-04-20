using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03
{
    public class GameManager : MonoBehaviour
    {
        public int Score;


        private static GameManager instance;
        public static GameManager Get()
        {
            return instance;
        }

        private void Awake()
        {
            instance = this;
        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UniverseCreator.Get().CreateUniverse();
            }
        }

        public void AddScore(int score)
        {
            Score += score;
        }
    }
}