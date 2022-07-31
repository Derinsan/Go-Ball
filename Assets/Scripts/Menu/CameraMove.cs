using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject mainCamera;
    bool moveRight = true;
    float speed = 1f;

    void FixedUpdate()
    {
        if (moveRight)
        {
            var pos = transform.position;
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x > 4f) moveRight = false;
        }
        else
        {
            var pos = transform.position;
            pos.x -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x < -4f) moveRight = true;
        }
    }
}























