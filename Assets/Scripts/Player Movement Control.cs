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

    }

    // Update is called once per frame
    void Update()
    {
        //MOVEMENT
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //left
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //right
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //look up for up dash
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //look down for down dash/smaller character
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            //jump
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            //dash (according to arrow controls, diagonal when up and direction pressed together)
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