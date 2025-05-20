using UnityEngine;

public class Scorer : MonoBehaviour
{
    int scoreKeeper = 0;
    void OnCollisionEnter(Collision collision)
    {
        scoreKeeper ++;
        Debug.Log("You bumped into " + scoreKeeper + " this many times");

    }
}
