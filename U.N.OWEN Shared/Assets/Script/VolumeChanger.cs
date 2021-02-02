using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    private static float AudioVolume = -1f;

    private AudioSource AudioSrc;
    public Slider slider;

    void Start()
    {
        AudioSrc = GetComponent<AudioSource>();

        if (AudioVolume >= 0f)
        {
            slider.value = AudioVolume;
        }
        else
        {
            slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        }
    }

    void Update()
    {
        AudioSrc.volume = AudioVolume;
    }

    public void SetVolume()
    {
        AudioVolume = slider.value;
    }

    public static void SetOldVol(float i)
    {
        AudioVolume = i;
    }

    public static float GetOldVol()
    {
        return AudioVolume;
    }

}
