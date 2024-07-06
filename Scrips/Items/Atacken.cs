using UnityEngine;

public class Atacken : MonoBehaviour
{
    [SerializeField] private GameObject _weapon;
    [SerializeField] private Transform _swordPosition;
    [SerializeField] private float _arrowForse;

    public float countArrow;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Attacke()
    {
        GameObject newArrow = Instantiate(_weapon, _swordPosition.transform.position , transform.rotation);
        Rigidbody2D _arrowRb = newArrow.GetComponent<Rigidbody2D>();

        if(_spriteRenderer.flipX)
        {
            _arrowRb.velocity = new Vector2(_arrowForse * -1, _arrowRb.velocity.y);
        }
        else 
        {
            _arrowRb.velocity = new Vector2(_arrowForse * 1, _arrowRb.velocity.y);
        }

        --countArrow;    
    }
}
