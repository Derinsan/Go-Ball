using UnityEngine;

public class RandomSet : MonoBehaviour
{
    [SerializeField] private Transform[] _setBox;
    [SerializeField] private GameObject _boxMost;
    [SerializeField] private Transform[] _setBridge;
    [SerializeField] private GameObject _bridge;
    [SerializeField] private Transform[] _setPalm;
    [SerializeField] private GameObject _palm;
    [SerializeField] private Transform[] _setLPM;
    [SerializeField] private GameObject _lpm;
    [SerializeField] private Transform[] _setWoodBoxFirst;
    [SerializeField] private GameObject _woodBoxFirst;
    [SerializeField] private Transform[] _setWoodBoxSecond;
    [SerializeField] private GameObject _woodBoxSecond;

    private void Start()
    {
        Vector3 positionBox = _setBox[Random.Range(0, _setBox.Length)].position;
        Instantiate(_boxMost, positionBox, Quaternion.identity);

        Vector3 positionMost = _setBridge[Random.Range(0, _setBridge.Length)].position;
        Instantiate(_bridge, positionMost, Quaternion.identity);

        Vector3 positionPalm = _setPalm[Random.Range(0, _setPalm.Length)].position;
        Instantiate(_palm, positionPalm, Quaternion.identity);

        Vector3 positionLPM = _setLPM[Random.Range(0, _setLPM.Length)].position;
        Instantiate(_lpm, positionLPM, Quaternion.identity);

        Vector3 positionWoodBoxFirst = _setWoodBoxFirst[Random.Range(0, _setWoodBoxFirst.Length)].position;
        Instantiate(_woodBoxFirst, positionWoodBoxFirst, Quaternion.identity);

        Vector3 positionWoodBoxSecond = _setWoodBoxSecond[Random.Range(0, _setWoodBoxSecond.Length)].position;
        Instantiate(_woodBoxSecond, positionWoodBoxSecond, Quaternion.identity);
    }
}
