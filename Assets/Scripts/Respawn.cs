using UnityEngine;

public class respawn : MonoBehaviour
{
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            Invoke("Respawn", 0.6f);
        }
    }
    public void Respawn()
    {
        if (player != null)
        {
                player.transform.position = new Vector3(-4.81f, -2.41f, 0);
                Debug.Log("Respawned");
         
        }
    }
}
