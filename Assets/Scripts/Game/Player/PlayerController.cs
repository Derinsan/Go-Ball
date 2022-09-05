using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isPlayerDead = false;
    Rigidbody _rigidbody;
    [SerializeField] private float _velocity = 6f;
    [SerializeField] private float _turnSpeed = 5f;
    float _moveHorizontal;
    [SerializeField] private Score _scoreScript;
    [SerializeField] AudioSource _playerDead;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        isPlayerDead = false;
    }

    void Start()
    {
        StartCoroutine(SpeedUp());
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_moveHorizontal * _turnSpeed, _rigidbody.velocity.y, _velocity);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("obstacles"))
        {
            Destroy(gameObject);
            isPlayerDead = true;
            int lastRunScore = int.Parse(_scoreScript._txt.text.ToString());
            PlayerPrefs.SetInt("lastRunScore", lastRunScore);
            _playerDead.Play();
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
        while (_velocity <= 11f)
        {
            yield return new WaitForSeconds(1f);
            _velocity += 0.03125f;
        }
    }
}
