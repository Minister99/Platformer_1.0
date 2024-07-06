using UnityEngine;

public class PlayerDeat : MonoBehaviour
{
    [SerializeField] private HpCharacter _hpCharacter;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _hpCharacter.playerHp = 0;
        }
    }
}
