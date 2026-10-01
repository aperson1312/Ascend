using UnityEditor.Build.Profile;
using UnityEngine;
using UnityEngine.SceneManagement;
public class teleport : MonoBehaviour
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

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            Invoke("Teleport", 0.3f);
            
        }
    }

    public void Teleport()
    {
        if (player!= null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Next Level");
        }
    }
}