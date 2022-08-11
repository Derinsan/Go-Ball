using UnityEngine;

public class RandomLevel2 : MonoBehaviour
{
    [SerializeField] private Transform[] _setSticks;
    [SerializeField] private GameObject _sticks;
    [SerializeField] private Transform[] _setLPN;
    [SerializeField] private GameObject _LPN;

    private void Start()
    {
        Vector3 position = _setSticks[Random.Range(0, _setSticks.Length)].position;
        Instantiate(_sticks, position, Quaternion.identity);

        Vector3 positionLPN = _setLPN[Random.Range(0, _setLPN.Length)].position;
        Instantiate(_LPN, positionLPN, Quaternion.identity);
    }
}
