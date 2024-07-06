using UnityEngine;

public class Thorns : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
