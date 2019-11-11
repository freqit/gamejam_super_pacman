using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PacManGame
{
    //Loads all necessary game objects (Game Manager)
    //Attaches to main camera

    public class GameLoader : MonoBehaviour
    {
        public static GameLoader instance;
        public GameObject gameManager;

        private void Awake()
        {
            instance = this;

            if (GameManager.instance == null)
            {
                Instantiate(gameManager);
            }
        }
    }
}