using UnityEngine;

public class EmemyMovement : MonoBehaviour
{
    [SerializeField] private GUIControler _guiControler;
    [SerializeField] private Transform[] _pointControl;
    
    public float speed;

    private SpriteRenderer _spriteRenderer;
    private Transform _target;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _target = _pointControl[0];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }
   
    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position , _target.position) <0.1f) 
        {
            _spriteRenderer.flipX = false;
            _target = (_target == _pointControl[0]) ? _pointControl[1] : _pointControl[1];
        }

        if (Vector2.Distance(transform.position, _pointControl[1].position) < 0.1f)
        {
            _spriteRenderer.flipX = true;

            _target = (_target == _pointControl[1]) ? _pointControl[0] : _pointControl[0];
        }
    }
}