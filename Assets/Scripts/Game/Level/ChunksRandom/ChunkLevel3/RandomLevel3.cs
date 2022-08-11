using UnityEngine;

public class RandomLevel3 : MonoBehaviour
{
    [SerializeField] private Transform[] _setBarrelBigFirst;
    [SerializeField] private GameObject _barrelBigFirst;
    [SerializeField] private Transform[] _setHurdleFirst;
    [SerializeField] private GameObject _hurdlefirst;
    [SerializeField] private Transform[] _setBarrelsFirst;
    [SerializeField] private GameObject _barrelsFirst;
    [SerializeField] private Transform[] _setBarrelBigSecond;
    [SerializeField] private GameObject _barrelBigSecond;
    [SerializeField] private Transform[] _setHurdleSecond;
    [SerializeField] private GameObject _hurdleSecond;
    [SerializeField] private Transform[] _setBarrelBigThird;
    [SerializeField] private GameObject _barrelBigThird;
    [SerializeField] private Transform[] _setHurdleThird;
    [SerializeField] private GameObject _hurdleThird;
    [SerializeField] private Transform[] _setBarrelBigFourth;
    [SerializeField] private GameObject _barrelBigFourth;

    private void Start()
    {
        Vector3 positionBarrel = _setBarrelBigFirst[Random.Range(0, _setBarrelBigFirst.Length)].position;
        Instantiate(_barrelBigFirst, positionBarrel, Quaternion.identity);

        Vector3 positionHurdle = _setHurdleFirst[Random.Range(0, _setHurdleFirst.Length)].position;
        Instantiate(_hurdlefirst, positionHurdle, Quaternion.identity);

        Vector3 positionBarrels = _setBarrelsFirst[Random.Range(0, _setBarrelsFirst.Length)].position;
        Instantiate(_barrelsFirst, positionBarrels, Quaternion.identity);

        Vector3 positionBarrelSecond = _setBarrelBigSecond[Random.Range(0, _setBarrelBigSecond.Length)].position;
        Instantiate(_barrelBigSecond, positionBarrelSecond, Quaternion.identity);

        Vector3 positionHurdleSecond = _setHurdleSecond[Random.Range(0, _setHurdleSecond.Length)].position;
        Instantiate(_hurdleSecond, positionHurdleSecond, Quaternion.identity);

        Vector3 positionBarrelThird = _setBarrelBigThird[Random.Range(0, _setBarrelBigThird.Length)].position;
        Instantiate(_barrelBigThird, positionBarrelThird, Quaternion.identity);

        Vector3 positionHurdleThird = _setHurdleThird[Random.Range(0, _setHurdleThird.Length)].position;
        Instantiate(_hurdleThird, positionHurdleThird, Quaternion.identity);

        Vector3 positionBarrelFourth = _setBarrelBigFourth[Random.Range(0, _setBarrelBigFourth.Length)].position;
        Instantiate(_barrelBigFourth, positionBarrelFourth, Quaternion.identity);
    }
}
