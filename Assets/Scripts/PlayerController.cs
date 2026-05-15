using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
   

    private float MovementY;
    private float MovementX;

    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        Vector2 newVelcoity = new Vector2(MovementX * speed, rb.linearVelocity.y);
        rb.linearVelocity = newVelcoity;
    }   

    public void onMove(InputAction.CallbackContext context)
    {
        MovementX = context.ReadValue<Vector2>().x;
    }
}
