using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PacManGame
{
    public class PacMan : MonoBehaviour
    {
        float Velocity = 8f;

        private Vector2 Direction;

        void Start()
        {

        }

        void Update()
        {
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

