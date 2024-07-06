using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Arrow"))
        {
            Destroy(gameObject);
        }
    }
}
