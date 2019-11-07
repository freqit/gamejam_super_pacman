using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace PacManGame
{
    // Static Class - Accessible to any script
    // Handles: Scene Loading only
    public static class SceneLoader
    {
        public static void LoadSceneByString(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
