using UnityEngine;

public class CoinsRotate : MonoBehaviour
{
    private void FixedUpdate()
    {
        gameObject.transform.Rotate(new Vector3(0f, 0f, 75f) * Time.deltaTime);
    }
}
