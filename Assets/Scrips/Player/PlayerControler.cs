using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jump = 4;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private GUIControler _guiControler;

    private HpCharacter _hpCharacter;
    private bool isGrounded;
    private Rigidbody2D _rigidbody2D;
    private float horizontalInput;
    private CircleCollider2D _circleCollider;

    public Vector2 movement;

    private void Start()
    {
        _circleCollider = GetComponent<CircleCollider2D>();
        _hpCharacter =GetComponent<HpCharacter>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void Update()
    {
        DestroyColider();
        IsGround();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Finish"))
        {
            _guiControler.IsWin();            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            _hpCharacter.DamagePlayer();
        }
    }

    private void IsGround()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    public void Move()
    {
        horizontalInput = Input.GetAxis(GlobalStringVars.horizontal);
        movement = new Vector2(horizontalInput * _moveSpeed, _rigidbody2D.velocity.y);
        _rigidbody2D.velocity = movement;  
    }

    public void Jump() 
    {
        if (Input.GetButton(GlobalStringVars.jump) && isGrounded)
        {
            _rigidbody2D.AddForce(Vector2.up * _jump * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }
    } 

    private void DestroyColider()
    {
        if (_hpCharacter.playerHp <= 0)
        {
            Destroy(_circleCollider);
        }
    }
}
