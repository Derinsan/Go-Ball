using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isPlayerDead = false;
    private Rigidbody _rigidbody;
    [SerializeField] private float Velocity = 6f;
    [SerializeField] private float _turnSpeed = 5f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _rigidbody.velocity.y, Velocity);

        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.left * _turnSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.right * _turnSpeed);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstacles")
        {
            Destroy(gameObject);
            isPlayerDead = true;
        }
    }
}
