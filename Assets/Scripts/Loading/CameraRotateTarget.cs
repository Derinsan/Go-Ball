using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateTarget : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private void FixedUpdate()
    {
        transform.RotateAround(target.transform.position, Vector3.down, 5 * Time.deltaTime);
    }
}
