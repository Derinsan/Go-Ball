using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //public float moveSpeed;
    public GameObject mainCamera;

    /*void FixedUpdate()
    {
        MoveObj();
    }

    void MoveObj()
    {
        float moveAmount = Time.smoothDeltaTime * moveSpeed;
        transform.Translate(0f, 0f, moveAmount);
        if (moveAmount == 47)
        {
            transform.Translate(0f, 0f, moveAmount);
        }
        else if (moveAmount <= -20)
        {
            transform.Translate(0f, 0f, -moveAmount);
        }
    }*/
    bool moveRight = true;
    float speed = 1f; //unit per second

    void Update()
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























