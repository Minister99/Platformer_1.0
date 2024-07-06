using UnityEngine;

public class ArrowsRaise : MonoBehaviour
{
    [SerializeField] private Atacken _atacken;

    private float _arrowsRaise = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _atacken.countArrow += _arrowsRaise;
            Destroy(gameObject);
        }
    }
}
