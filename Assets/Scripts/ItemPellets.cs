using UnityEngine;

namespace PacManGame.Items
{
    public class ItemPellets : PickupItemBase
    {
        void Start()
        {

        }

        void Update()
        {

        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == Constants.TAG_PLAYER)
            {
                // add score then destroy this

                Destroy(gameObject);
            }
        }
    }
}
