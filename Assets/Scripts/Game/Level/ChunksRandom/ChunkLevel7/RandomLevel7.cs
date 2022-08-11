using UnityEngine;

public class RandomLevel7 : MonoBehaviour
{
    [SerializeField] private Transform[] _setRockFirst;
    [SerializeField] private GameObject _rockFirst;
    [SerializeField] private Transform[] _setHurdleFirst;
    [SerializeField] private GameObject _hurdleFirst;
    [SerializeField] private Transform[] _setSpikes;
    [SerializeField] private GameObject _spikes;
    [SerializeField] private Transform[] _setRockSecond;
    [SerializeField] private GameObject _rockSecond;
    [SerializeField] private Transform[] _setLarge;
    [SerializeField] private GameObject _large;

    private void Start()
    {
        Vector3 posRockFirst = _setRockFirst[Random.Range(0, _setRockFirst.Length)].position;
        Instantiate(_rockFirst, posRockFirst, Quaternion.identity);

        Vector3 posHurdleFirst = _setHurdleFirst[Random.Range(0, _setHurdleFirst.Length)].position;
        Instantiate(_hurdleFirst, posHurdleFirst, Quaternion.identity);

        Vector3 posSpikes = _setSpikes[Random.Range(0, _setSpikes.Length)].position;
        Instantiate(_spikes, posSpikes, Quaternion.identity);

        Vector3 posRockSecond = _setRockSecond[Random.Range(0, _setRockSecond.Length)].position;
        Instantiate(_rockSecond, posRockSecond, Quaternion.identity);

        Vector3 posLarge = _setLarge[Random.Range(0, _setLarge.Length)].position;
        Instantiate(_large, posLarge, Quaternion.identity);
    }
}
