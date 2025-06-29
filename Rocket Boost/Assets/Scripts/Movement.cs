using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnEnable()
    {
        thrust.Enable();
    }
    private void FixedUpdate()
    {
        if (thrust.IsPressed())
        {
            Debug.Log("THRUST!!!");
        }
    }
}
