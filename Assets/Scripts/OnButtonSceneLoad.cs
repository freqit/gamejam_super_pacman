using UnityEngine;

namespace PacManGame
{
    // Handles: Loads any scene on button click using unity UI button events
    public class OnButtonSceneLoad : MonoBehaviour
    {
        public string SceneToLoad;

        public void OnClick()
        {
            SceneLoader.LoadSceneByString(SceneToLoad);
        }
    }
}
