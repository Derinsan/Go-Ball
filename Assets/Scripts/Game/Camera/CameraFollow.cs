using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - _player.transform.position;
    }

    private void Update()
    {
        if (PlayerController.isPlayerDead == false)
        {
            transform.position = _player.transform.position + _offset;
        }
    }
}
