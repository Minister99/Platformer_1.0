using UnityEngine;

public class CoinRaise : MonoBehaviour
{
    private int _coinRaise = 1;
   
    [SerializeField]private BonusItems _bonusItems;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _bonusItems.coinNumber += _coinRaise;
            Destroy(gameObject);
        }
    }
}
