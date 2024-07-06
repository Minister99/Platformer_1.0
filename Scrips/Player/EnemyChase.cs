using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;
    public float chaseSpeed = 2f;
    private bool isChasing = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isChasing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isChasing = false;
        }
    }

    private void Update()
    {
        if (isChasing && player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.position, chaseSpeed * Time.deltaTime);
        }
    }
}
