using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") {
            Destroy(other.gameObject);
        }
    }
}
