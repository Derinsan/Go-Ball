using System.Collections;
using UnityEngine;

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
        StartCoroutine(SpeedUp());
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_moveHorizontal * _turnSpeed, _rigidbody.velocity.y, Velocity);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstacles")
        {
            Destroy(gameObject);
            isPlayerDead = true;
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Climb")
        {
            Velocity = 6;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpeedUpMoment")
        {
            Velocity = 9f;
        }

        if (other.gameObject.tag == "SpeedDownMoment")
        {
            Velocity = 8f;
        }
    }

    public void MoveLeft()
    {
        _moveHorizontal = -1f;
    }

    public void MoveRight()
    {
        _moveHorizontal = 1f;
    }

    public void StopMoveHorizontal()
    {
        _moveHorizontal = 0f;
    }

    IEnumerator SpeedUp()
    {
        while (Velocity <= 8.50)
        {
            yield return new WaitForSeconds(8f);
            Velocity += 0.25f;
        }
    }
}
