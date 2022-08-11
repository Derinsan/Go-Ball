using UnityEngine;

public class RotatePlayerSkin : MonoBehaviour
{
    [SerializeField] private GameObject _playerSkin;

    private void FixedUpdate()
    {
        _playerSkin.transform.Rotate(new Vector3(110f, 0, 0f) * Time.deltaTime);
    }
}
