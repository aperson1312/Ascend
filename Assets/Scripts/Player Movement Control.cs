using UnityEngine;

public class Control : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float jumpForce = 10f;
    public float dashSpeed = 20f;
    public bool isGrounded = true; // wall is true to check for wall jump and wall slide maybe...
    public bool canDash = true;
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
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movement.x = 1;
            //left
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movement.x = -1;
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

        if (Input.GetKeyDown(KeyCode.C) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            //jump
        }

        if (Input.GetKeyDown(KeyCode.X) && canDash)
        {
            Vector2 dashDirection = movement;
            canDash = false;

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                dashDirection.x = 5;
                //dash right
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                dashDirection.x = -5;
                //dash left
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                dashDirection.y = 5;
                //dash up
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))//and not touching ground
            {
                dashDirection.y = -5;
                //dash down
            }
        }    //dash (according to arrow controls, diagonal when up and direction pressed together)

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(""))
        {
            canDash = true;
            //dash reset
        }

        if (collision.gameObject.CompareTag(""))
        {
            //wall jump
        }

        if (collision.gameObject.CompareTag("") && Input.GetKeyDown(KeyCode.RightArrow))
        {
            //slow wall slide right
        }

        if (collision.gameObject.CompareTag("") && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //slow wall slide left
        }
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