using UnityEngine;

namespace PacManGame
{
    // PacMan player scripts
    // Handles: Movement, User inputs, Collision detection
    public class PacMan : BaseCreature
    {


        [Header("Screen Wrapping")]
        public GameObject LeftHorizontalPlayerBounds;
        public GameObject TopVerticalPlayerBounds;

        // Private Variables
        private Vector2 Direction;

        void Start()
        {

        }

        void Update()
        {
            // TODO(JOAKIM): Change screenwrapping to set with empty gameobjects
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
                // TODO(JOAKIM): Move to userinput()
                Direction = Vector2.zero;
            }
        }

        public void UserInput()
        {
            // TODO(JOAKIM): Add gamepad support
            // IF INPUT NOT 0 move, else vector2.zero
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

