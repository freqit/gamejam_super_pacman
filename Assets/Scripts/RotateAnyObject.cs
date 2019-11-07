using UnityEngine;

namespace PacManGame
{
    // Handles: Rotates any object in Z-axis
    public class RotateAnyObject : MonoBehaviour
    {
        public float RotationSpeed = 0.2f;

        void Update()
        {
            RotateObject();
        }

        public void RotateObject()
        {
            transform.Rotate(new Vector3(transform.position.x, transform.position.y, RotationSpeed), Space.Self);
        }
    }
}
