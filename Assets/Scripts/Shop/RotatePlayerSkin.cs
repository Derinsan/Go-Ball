using UnityEngine;

public class RotatePlayerSkin : MonoBehaviour
{
    [SerializeField] private GameObject _playerSkin;

    private void FixedUpdate()
    {
        _playerSkin.transform.Rotate(new Vector3(-90f, 0, 60f) * Time.deltaTime);
    }
}
