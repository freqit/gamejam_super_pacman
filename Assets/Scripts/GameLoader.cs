using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PacManGame
{
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