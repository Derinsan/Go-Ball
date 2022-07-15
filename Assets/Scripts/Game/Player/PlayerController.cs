using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public static bool isPlayerDead = false;
    private Rigidbody _rigidbody;
    [SerializeField] private float Velocity = 6f;
    [SerializeField] private float _turnSpeed = 5f;
    [SerializeField] private float _moveHorizontal;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //transform.Translate(0.0f, 0f, 6f * Time.deltaTime);
        _rigidbody.velocity = new Vector3(_moveHorizontal * _turnSpeed, _rigidbody.velocity.y, Velocity);
        //Vector3 movement = new Vector3(_moveHorizontal, 0.0f, 0.0f);

        /*if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.left * _turnSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.right * _turnSpeed);
        }*/
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstacles")
        {
            Destroy(gameObject);
            isPlayerDead = true;
        }
    }

    public void MoveLeft()
    {
        _moveHorizontal = -1f;
        //_rigidbody.AddForce(Vector3.left * _turnSpeed);
    }

    public void MoveRight()
    {
        _moveHorizontal = 1f;
        //_rigidbody.AddForce(Vector3.right * _turnSpeed);
    }

    public void StopMoveHorizontal()
    {
        _moveHorizontal = 0f;
        //_rigidbody.AddForce(0, 0, 0);
    }
}
