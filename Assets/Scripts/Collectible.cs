using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int pointsValue = 10;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.AddScore(pointsValue);
            Destroy(gameObject);
        }
    }
}