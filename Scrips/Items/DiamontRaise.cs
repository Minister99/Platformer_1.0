using UnityEngine;

public class DiamontRaise : MonoBehaviour
{
    private int _diamontRaise = 1;

    [SerializeField] private BonusItems _bonusItems;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _bonusItems.diamontNumber += _diamontRaise; 
            Destroy(gameObject);
        }
    }
}
