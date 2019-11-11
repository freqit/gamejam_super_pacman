using UnityEngine;

namespace PacManGame
{
    // Game Manager Singleton
    // Handles: Current Score, Player Lives, Player Respawns
    public sealed class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public int Score = 0;
        public Grid grid;

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

            grid = new Grid();
            grid.CreateGrid(1, 1, 1f);
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

        private void OnDrawGizmos()
        {

        }
    }
}
