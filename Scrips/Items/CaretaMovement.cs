using UnityEngine;

public class CaretaMovement : MonoBehaviour
{
    private HingeJoint2D _hingeJoint;

    private void Awake()
    {
        _hingeJoint = GetComponent<HingeJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _hingeJoint.useMotor = true;
        }
    }
}
