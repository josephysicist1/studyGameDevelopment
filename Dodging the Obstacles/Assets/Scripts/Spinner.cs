using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float xRotation = 0f;
    [SerializeField]float yRotation = 0.5f;
    [SerializeField]float zRotation = 0f;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(xRotation,yRotation,zRotation);
    }
}
