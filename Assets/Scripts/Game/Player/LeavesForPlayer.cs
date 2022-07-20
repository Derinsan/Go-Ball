using UnityEngine;

public class LeavesForPlayer : MonoBehaviour
{
    [SerializeField] private new ParticleSystem particleSystem;

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void FixedUpdate()
    {
        particleSystem.transform.rotation = Quaternion.Euler(0f, 178.4f, 0f);
    }
}
