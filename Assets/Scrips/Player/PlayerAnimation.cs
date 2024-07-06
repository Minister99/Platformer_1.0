using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private PlayerControler _playerControler;
    private SpriteRenderer _spriteRenderer;
    private Atacken _atacken;
    private HpCharacter _hpCharacter;

    private void Start()
    {
        _hpCharacter = GetComponent<HpCharacter>();
        _playerControler = GetComponent<PlayerControler>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _atacken = GetComponent<Atacken>();
    }

    private void Update()
    {
        AnimatiomOn();
        AnimationOf();
    }

    private void AnimatiomOn()
    {
        if(_playerControler.movement.x >= 0.1f)
        {
            _spriteRenderer.flipX = false;
            _animator.SetBool("IsWalking", true);
        }

        if (_playerControler.movement.x < -0.1f)
        {
            _spriteRenderer.flipX = true;
            _animator.SetBool("IsWalking", true);
        }

        if (_atacken.countArrow > 0)
        {
            if (Input.GetButtonDown(GlobalStringVars.Fire2))
            {
                _animator.SetBool("IsShot", true);
            }
        }

        if (_hpCharacter.playerHp <= 0)
        {
            _animator.SetBool("IsDeath", true);
        }
    }

    private void AnimationOf() 
    {
        if (_playerControler.movement.x == 0f)
        {
            _animator.SetBool("IsWalking", false);
        }

        if (Input.GetButtonUp(GlobalStringVars.Fire2))
        {
            _animator.SetBool("IsShot", false);
        }
    }
}
