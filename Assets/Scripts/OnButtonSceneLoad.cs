using UnityEngine;

namespace PacManGame
{
    public class OnButtonSceneLoad : MonoBehaviour
    {
        public void OnClick()
        {
            SceneLoader.LoadSceneByString("Joakim");
        }
    }
}
