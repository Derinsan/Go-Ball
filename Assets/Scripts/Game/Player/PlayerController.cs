using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isPlayerDead = false;
    Rigidbody _rigidbody;
    [SerializeField] private float Velocity = 6f;
    [SerializeField] private float _turnSpeed = 5f;
    private float speed;
    float _moveHorizontal;
    [SerializeField] private Score _scoreScript;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(SpeedUp());
        isPlayerDead = false;
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
            int lastRunScore = int.Parse(_scoreScript._txt.text.ToString());
            PlayerPrefs.SetInt("lastRunScore", lastRunScore);
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
        while (Velocity <= 9.25f)
        {
            yield return new WaitForSeconds(8f);
            Velocity += 0.25f;
        }
    }
}
