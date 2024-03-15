using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SoundSettings : MonoBehaviour
{
    [SerializeField] Slider sound_Slider;
    [SerializeField] AudioMixer sound_Mastermixer;

    void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("SavedMasterVolume", 100));
    }

    public void SetVolume(float sound_Value)
    {
        if(sound_Value < 1)
        {
            sound_Value = .001f;
        }

        RefreshSlider(sound_Value);
        PlayerPrefs.SetFloat("SavedMasterVolume", sound_Value);
        sound_Mastermixer.SetFloat("MasterVolume", Mathf.Log10(sound_Value / 100) * 20f);
    }

    public void SetVolumeFromSlider()
    {
        SetVolume(sound_Slider.value);
    }

    public void RefreshSlider(float sound_Value)
    {
        sound_Slider.value = sound_Value;
    }
}
