using UnityEngine;

public class PlatformControler : MonoBehaviour
{
    private SliderJoint2D _sliderJoint2D;
    private JointMotor2D _motor;

    [SerializeField] private float _speed  = 0;

    private void Awake()
    {
        _sliderJoint2D = GetComponent<SliderJoint2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _motor = _sliderJoint2D.motor;
            _motor.motorSpeed = -_speed;
            _sliderJoint2D.motor = _motor;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            _motor = _sliderJoint2D.motor;
            _motor.motorSpeed = _speed;
            _sliderJoint2D.motor = _motor;
        }
    }
}
