using UnityEngine;

public class RandomLevel4 : MonoBehaviour
{
    [SerializeField] private Transform[] _setBarricadeFirst;
    [SerializeField] private GameObject _barricadeFirst;
    [SerializeField] private Transform[] _setBarricadeSecond;
    [SerializeField] private GameObject _barricadeSecond;
    [SerializeField] private Transform[] _setBarricadeThird;
    [SerializeField] private GameObject _barricadeThird;
    [SerializeField] private Transform[] _setBarricadeFourth;
    [SerializeField] private GameObject _barricadeFourth;
    [SerializeField] private Transform[] _setBarrelGroupFirst;
    [SerializeField] private GameObject _barrelGroupFirst;

    private void Start()
    {
        Vector3 positionBarricadeFirst = _setBarricadeFirst[Random.Range(0, _setBarricadeFirst.Length)].position;
        Instantiate(_barricadeFirst, positionBarricadeFirst, Quaternion.identity);

        Vector3 positionBarricadeSecond = _setBarricadeSecond[Random.Range(0, _setBarricadeSecond.Length)].position;
        Instantiate(_barricadeSecond, positionBarricadeSecond, Quaternion.identity);

        Vector3 positionBarricadeThird = _setBarricadeThird[Random.Range(0, _setBarricadeThird.Length)].position;
        Instantiate(_barricadeThird, positionBarricadeThird, Quaternion.identity);

        Vector3 positionBarricadeFourth = _setBarricadeFourth[Random.Range(0, _setBarricadeFourth.Length)].position;
        Instantiate(_barricadeFourth, positionBarricadeFourth, Quaternion.identity);

        Vector3 positionBarrelGroupFirst = _setBarrelGroupFirst[Random.Range(0, _setBarrelGroupFirst.Length)].position;
        Instantiate(_barrelGroupFirst, positionBarrelGroupFirst, Quaternion.identity);
    }
}
