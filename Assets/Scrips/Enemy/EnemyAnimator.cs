using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    private Animator  _animator;
    private EmemyMovement _ememyMovement;

    private void Start()
    {
        _ememyMovement = GetComponent<EmemyMovement>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        AnimationOn();
        AnimationOff();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _ememyMovement.speed = 0;
            _animator.SetBool("IsAtaack", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _ememyMovement.speed = 2;
            _animator.SetBool("IsAtaack", false);
        }
    }

    private void AnimationOn()
    {
        if (_ememyMovement.speed > 0.1f)
        {
            _animator.SetBool("Walk", true);
        }
    }

    private void AnimationOff()
    {
        if (_ememyMovement.speed == 0f)
        {
            _animator.SetBool("Walk", false);
        }
    }
}
