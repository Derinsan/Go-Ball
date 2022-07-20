using UnityEngine;

public class RandomSet : MonoBehaviour
{
    [SerializeField] private Transform[] _setBox;
    [SerializeField] private GameObject _boxMost;

    private void Start()
    {
        Vector3 position = _setBox[Random.Range(0, _setBox.Length)].position;
        Instantiate(_boxMost, position, Quaternion.identity);
    }
}
