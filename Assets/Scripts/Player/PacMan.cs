using UnityEngine;

namespace PacManGame
{
    public class PacMan : MonoBehaviour
    {
        [Header("Movement Variables")]
        public float Velocity = 12f;

        private Vector2 Direction;

        void Start()
        {

        }

        void Update()
        {
            if (transform.position.x < -32)
            {
                transform.position = new Vector2(32, transform.position.y);
            }

            if (transform.position.x > 32)
            {
                transform.position = new Vector2(-32, transform.position.y);
            }

            UserInput();
            Move();
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer(Constants.LAYER_WALL))
            {
                Direction = Vector2.zero;
            }
        }

        public void UserInput()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Direction = Vector2.left;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Direction = Vector2.right;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                Direction = Vector2.up;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Direction = Vector2.down;
            }
        }

        public void Move()
        {
            transform.Translate(Direction * Velocity * Time.deltaTime);
        }
    }
}

