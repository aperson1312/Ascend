using UnityEngine;

public class Control : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float jumpForce = 10f;
    public float dashSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector2.zero; //player stays still when no keys are pressed
        //MOVEMENT
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movement.x = -1;
            //left
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movement.x = 1;
            //right
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //look up
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //smaller character
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            //jump
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector2 dashDirection = movement;

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                dashDirection.x = 1;
                //dash right
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                dashDirection.x = -1;
                //dash left
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                dashDirection.y = 1;
                //dash up
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))//and not touching ground
            {
                dashDirection.y = -1;
                //dash down
            }
        }    //dash (according to arrow controls, diagonal when up and direction pressed together)
        
    }
}

//Dash reset on collision with berry/gem/balloon

/* (GPT)
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Vector2.zero;

        // Arrow Keys
        if (Input.GetKey(KeyCode.LeftArrow))
            movement.x = -1;

        if (Input.GetKey(KeyCode.RightArrow))
            movement.x = 1;

        if (Input.GetKey(KeyCode.UpArrow))
            movement.y = 1;

        if (Input.GetKey(KeyCode.DownArrow))
            movement.y = -1;

        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}*/