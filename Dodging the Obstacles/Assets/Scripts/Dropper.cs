using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > timeToWait)
        {
            Debug.Log("Start falling!!!");
        }   
    }
}
