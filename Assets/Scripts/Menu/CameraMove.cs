using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject mainCamera;
    bool _moveRight = true;
    float _speed = 1f;

    void FixedUpdate()
    {
        if (_moveRight)
        {
            var pos = transform.position;
            pos.x += _speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x > 4f) _moveRight = false;
        }
        else
        {
            var pos = transform.position;
            pos.x -= _speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x < -4f) _moveRight = true;
        }
    }
}























