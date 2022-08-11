using UnityEngine;

public class RandomSetChunkLevel : MonoBehaviour
{
    [SerializeField] private Transform[] _setFirstPalm;
    [SerializeField] private GameObject _firstPalm;
    [SerializeField] private Transform[] _setHirdleFirst;
    [SerializeField] private GameObject _firstHirdle;
    [SerializeField] private Transform[] _setHirdleSecond;
    [SerializeField] private GameObject _secondHirdle;
    [SerializeField] private Transform[] _setFence;
    [SerializeField] private GameObject _fence;

    private void Start()
    {
        Vector3 positionFirstPalm = _setFirstPalm[Random.Range(0, _setFirstPalm.Length)].position;
        Instantiate(_firstPalm, positionFirstPalm, Quaternion.identity);

        Vector3 positionFirstHirdle = _setHirdleFirst[Random.Range(0, _setHirdleFirst.Length)].position;
        Instantiate(_firstHirdle, positionFirstHirdle, Quaternion.identity);

        Vector3 positionSecondHirdle = _setHirdleSecond[Random.Range(0, _setHirdleSecond.Length)].position;
        Instantiate(_secondHirdle, positionSecondHirdle, Quaternion.identity);

        Vector3 positionFence = _setFence[Random.Range(0, _setFence.Length)].position;
        Instantiate(_fence, positionFence, Quaternion.identity);
    }
}
