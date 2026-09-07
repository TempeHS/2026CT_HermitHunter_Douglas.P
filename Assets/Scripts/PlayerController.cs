using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    bool isFacingRight = false;

    public float speed = 5f;
    public float jumpForce = 7f;
    public float acceleration = 5f;


    private float MovementY;
    private float MovementX;
    private float nun = 0f;

    public Rigidbody2D rb;
    public Animator animator;

    public Transform groundCheckPos;
    public Vector2 groundCheckSize = new Vector2( 0.5f, 0.5f);
    public LayerMask groundLayer;

    private Death death;    

    public Death Deathscript;
    public bool Alivecheck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        death = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {
        float targetSpeed = MovementX * speed;
        float newX = Mathf.MoveTowards(
            rb.linearVelocity.x,
            targetSpeed,
            acceleration * Time.deltaTime
        );
        Vector2 newVelcoity = new Vector2(newX, rb.linearVelocity.y);
        rb.linearVelocity = newVelcoity;
        Flip();
        
        animator.SetFloat("Magnitude", rb.linearVelocity.magnitude);

        if (Input.GetKeyDown("h"))
        {
            death.Dead();
        }

        Alivecheck = Deathscript.IsAlive;
        
    }

    private void Flip()
    {
        if (isFacingRight && MovementX < 0 || !isFacingRight && MovementX > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
    // add an initial slow to the movment, mabye decrease acceleration, cuz water resists movement more than air    
    public void OnMove(InputAction.CallbackContext context)
    {
        if(Alivecheck == true){
        MovementX = context.ReadValue<Vector2>().x;
        }
        else{
            Debug.Log("mmmmmm i like little russian men");
            MovementX = nun;
        }
    }   

    public void onJump(InputAction.CallbackContext context)
    {
        if (isGrounded())
        {
            if(context.performed)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
                animator.SetTrigger("jump");
            }
            else if (context.canceled && rb.linearVelocity.y > 0)
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
            }
        }
    }
    
    private bool isGrounded()
    {
        if (Physics2D.OverlapBox(groundCheckPos.position, groundCheckSize, 0 , groundLayer))
        {
            return true;
        }
        return false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(groundCheckPos.position, groundCheckSize);
    }
}
