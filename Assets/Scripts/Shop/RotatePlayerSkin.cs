using UnityEngine;

public class RotatePlayerSkin : MonoBehaviour
{
    [SerializeField] private GameObject _playerSkin;
    [SerializeField] private GameObject _coinSprite;
    [SerializeField] private GameObject _coinSpriteBuy;

    private void FixedUpdate()
    {
        _playerSkin.transform.Rotate(new Vector3(110f, 0, 0f) * Time.deltaTime);
        _coinSprite.transform.Rotate(new Vector3(0f, 120f, 0f) * Time.deltaTime);
        _coinSpriteBuy.transform.Rotate(new Vector3(0f, 60f, 0f) * Time.deltaTime);
    }
}
