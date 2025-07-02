using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    Vector2 movement;

    void Update()
    {
        ProcessTranslation();
    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    void ProcessTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float yOffset = movement.y * controlSpeed * Time.deltaTime;

        Vector3 currentPos = transform.localPosition;

        
        transform.localPosition = new Vector3(currentPos.x + xOffset, currentPos.y + yOffset, 0f); 
    }
}
