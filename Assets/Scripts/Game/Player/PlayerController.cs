using System.Collections;
using System.Collections.Generic;
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

    }
}
