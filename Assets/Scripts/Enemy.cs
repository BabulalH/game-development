using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float detectionRange = 5f;
    
    private Transform player;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>().transform;
    }

    private void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, player.position) < detectionRange)
        {
            ChasePlayer();
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void ChasePlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        rb.velocity = direction * speed;
    }
}