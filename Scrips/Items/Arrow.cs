using UnityEngine;

public class Arrow : MonoBehaviour
{
    private float _destroyGameObject = 1.5f;

    private void Update()
    {
        Destroy(gameObject, _destroyGameObject);
    }
}
