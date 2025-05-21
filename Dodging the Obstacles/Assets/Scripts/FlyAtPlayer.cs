using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, 1f);
    }
}
