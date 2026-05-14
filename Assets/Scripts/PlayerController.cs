using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public float speed = 0f;

    private float MovementY;
    private float MovementX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, speed);
    }
}
