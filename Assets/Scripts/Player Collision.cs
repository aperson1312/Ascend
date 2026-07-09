using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("spike"))
        {
            //respawn player at the start of the level
        }

        if (collision.gameObject.CompareTag("teleporter"))
        {
            //teleport player to the next level
        }
    }
}
