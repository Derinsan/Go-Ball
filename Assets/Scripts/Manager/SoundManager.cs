using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioMixerGroup Mixer;
    [SerializeField] AudioSource audioSource;

    public void ToggleMusic(bool enabled)
    {
        if (enabled)
        {
            Mixer.audioMixer.SetFloat("MusicVolume", 0);
        }
        else
        {
            Mixer.audioMixer.SetFloat("MusicVolume", -80);
        }

        PlayerPrefs.SetInt("MusicEnabled", enabled ? 1 : 0);
        audioSource.Play();
    }

    public void ToggleEffects(bool enabled)
    {
        if (enabled)
        {
            Mixer.audioMixer.SetFloat("EffectsVolume", 0);
        }
        else
        {
            Mixer.audioMixer.SetFloat("EffectsVolume", -80);
        }

        PlayerPrefs.SetInt("EffectsEnabled", enabled ? 1 : 0);
        audioSource.Play();
    }
}
