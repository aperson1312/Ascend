using UnityEngine;

public class Respawn : MonoBehaviour
{
    public static Respawn Instance { get; private set; }
    public GameObject player;

    private void Awake()
    {
        // Enforce the Singleton pattern
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    public void RespawnPlayer()
    {
        Invoke("InvokeRespawn", 0.4f);
    }
    public void InvokeRespawn()
    {
        if (player != null)
        {
            Instantiate(player, new Vector2(-4.81f, -2.41f), Quaternion.identity);
            player.transform.position = new Vector3(-4.81f, -2.41f, 0);
        }
    }
}
