using UnityEngine;

namespace PacManGame
{
    public class OnButtonSceneLoad : MonoBehaviour
    {
        public string SceneToLoad;

        public void OnClick()
        {
            SceneLoader.LoadSceneByString(SceneToLoad);
        }
    }
}
