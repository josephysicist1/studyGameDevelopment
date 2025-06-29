using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction rotation;
    [SerializeField] int thrustStrength = 1000;
    [SerializeField] float rotationStrength = 100f;
    AudioSource audioSource;
    Rigidbody rb;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }
    void OnEnable()
    {
        thrust.Enable();
        rotation.Enable();
    }
    private void FixedUpdate()
    {
        ProcessThrust();
        ProcessRotation();
    }
    private void ProcessThrust()
    {
        if (thrust.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime);
            if (!audioSource.isPlaying)
            {   
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
    private void ProcessRotation()
    {
        float rotationInput = rotation.ReadValue<float>();
        if (rotationInput > 0)
        {
            // transform.Rotate(Vector3.back * rotationStrength * Time.fixedDeltaTime); 
            // transform.Rotate(-Vector3.forward);
            ApplyRotation(-rotationStrength);     
        }
        else if (rotationInput < 0)
        {
            ApplyRotation(rotationStrength);
        }
    }
    private void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.fixedDeltaTime);
        rb.freezeRotation = false;
    }
}
    