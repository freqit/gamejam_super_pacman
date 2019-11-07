using UnityEngine;

namespace PacManGame
{
    // Game Manager Singleton
    // Handles: Current Score, Player Lives, Player Respawns
    public sealed class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public int Score = 0;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
            DontDestroyOnLoad(gameObject);
        }

        void Start()
        {

        }

        void Update()
        {

        }

        public void AddScore(int amount)
        {
            Score += amount;
        }
    }
}
