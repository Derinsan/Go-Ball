using UnityEngine;

public class RandomLevel5 : MonoBehaviour
{
    [SerializeField] private Transform[] _setBoxFirst;
    [SerializeField] private GameObject _boxFirst;
    [SerializeField] private Transform[] _setBoxSecond;
    [SerializeField] private GameObject _boxSecond;
    [SerializeField] private Transform[] _setLog;
    [SerializeField] private GameObject _log;
    [SerializeField] private Transform[] _setCauldron;
    [SerializeField] private GameObject _cauldron;

    private void Start()
    {
        Vector3 positionBoxFirst = _setBoxFirst[Random.Range(0, _setBoxFirst.Length)].position;
        Instantiate(_boxFirst, positionBoxFirst, Quaternion.identity);

        Vector3 positionBoxSecond = _setBoxSecond[Random.Range(0, _setBoxSecond.Length)].position;
        Instantiate(_boxSecond, positionBoxSecond, Quaternion.identity);

        Vector3 positionLog = _setLog[Random.Range(0, _setLog.Length)].position;
        Instantiate(_log, positionLog, Quaternion.identity);

        Vector3 positionCauldron = _setCauldron[Random.Range(0, _setCauldron.Length)].position;
        Instantiate(_cauldron, positionCauldron, Quaternion.identity);
    }
}
