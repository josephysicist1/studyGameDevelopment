using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]int moveSpeed = 10;
      void Start()
    {
        PrintInstruction();
    }
    void Update()
    {
        MovePlayer();
        
    }
    void PrintInstruction()
    {
        Debug.Log("Welcome to the Game!");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; 
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
