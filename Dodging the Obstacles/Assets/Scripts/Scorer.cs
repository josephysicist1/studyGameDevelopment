using UnityEditor.Rendering;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int scoreKeeper = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            scoreKeeper++;
            Debug.Log("You bumped into " + scoreKeeper + " this many times");

        }
    }
}
