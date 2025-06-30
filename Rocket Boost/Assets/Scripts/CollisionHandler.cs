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
                break;
            case "Fuel":
                Debug.Log("FUEL");
                break;
            default:
                Debug.Log("CRASHED");
                SceneManager.LoadScene(0);
                break;

        }
    }
}
