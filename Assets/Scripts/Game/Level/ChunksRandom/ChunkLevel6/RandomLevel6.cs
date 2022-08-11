using UnityEngine;

public class RandomLevel6 : MonoBehaviour
{
    [SerializeField] private Transform[] _setStone;
    [SerializeField] private GameObject _stone;

    private void Start()
    {
        Vector3 positionStone = _setStone[Random.Range(0, _setStone.Length)].position;
        Instantiate(_stone, positionStone, Quaternion.identity);
    }
}
