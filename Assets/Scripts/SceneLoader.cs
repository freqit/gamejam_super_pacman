using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace PacManGame
{
    // Static class so its accessible in any script
    public static class SceneLoader
    {
        public static void LoadSceneByString(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
