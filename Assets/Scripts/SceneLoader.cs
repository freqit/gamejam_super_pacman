using UnityEngine.SceneManagement;

namespace PacManGame
{
    // Static Class - Accessible to any script
    // Handles: Scene Loading and Scene Management
    public static class SceneLoader
    {
        public static void LoadSceneByString(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
