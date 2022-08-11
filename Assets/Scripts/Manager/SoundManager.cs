using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    private float musicVolume = 1f;
    public AudioMixer audioMixer;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        _audioSource.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

    public void SaveSettings()
    {
        audioMixer.SetFloat("MasterVolume", musicVolume);
    }
}
