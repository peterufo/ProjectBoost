using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
        void OnCollisionEnter(Collision other)
        {
            switch (other.gameObject.tag)
            {
                case "Finish":
                    LoadNextLevel();
                    break;
                case "Friendly":
                    Debug.Log("This object is friendly. Yay!");
                    break;
                default:
                    RestartLevel();
                    break;
        }
        }

    void LoadNextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        int nextLevel = currentLevel + 1;
        if (nextLevel == SceneManager.sceneCountInBuildSettings)
        {
            nextLevel = 0;
        }
        SceneManager.LoadScene(nextLevel);
    }
    void RestartLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel);
    }
}
