using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("BEGIN");
                break;
            case "Finish":
                Debug.Log("FINISH");
                LoadNextLevel();
                break;
            case "Fuel":
                Debug.Log("FUEL");
                break;
            default:
                StartCrashSequence();
                break;

        }
    }
    void StartCrashSequence()
    {
        Invoke("ReloadLevel", 2f);
    }
    void LoadNextLevel()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene == SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 0;
         }
        SceneManager.LoadScene(nextScene);
    }
    void ReloadLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
