using UnityEngine;

public class HpCharacter : MonoBehaviour
{
    [SerializeField] private GUIControler _gUIControler;

    private float _enemyDamage = 0.2f;
    private float _trapDamage = 0.5f;

    public float playerHp = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacles"))
        {
            playerHp -= _trapDamage;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            playerHp -= _trapDamage;
            _gUIControler.hpPlayer.fillAmount = playerHp;
        }
    }

    public void DamagePlayer() 
    {
        playerHp -= _enemyDamage;
        _gUIControler.hpPlayer.fillAmount = playerHp;
    }
}
