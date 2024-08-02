using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixer BGM;
    public Slider BGMslider;

    public AudioMixer SFX;
    public Slider SFXslider;

    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadMusicVolume();
        }
        else
        {
            SetMusicVolume();
        }

        if (PlayerPrefs.HasKey("effectVolume"))
        {
            LoadSFXVolume();
        }
        else
        {
            SetSFXVolume();
        }
    }
    public void SetMusicVolume()
    {
        float BgmVolume = BGMslider.value;
        BGM.SetFloat("BGM", Mathf.Log10(BgmVolume) * 20);
        PlayerPrefs.SetFloat("musicVolume", BgmVolume);
        PlayerPrefs.Save();
    }

    public void LoadMusicVolume()
    {
        BGMslider.value = PlayerPrefs.GetFloat("musicVolume");
        SetMusicVolume();
    }


    public void SetSFXVolume()
    {
        float sfxVolume = SFXslider.value;
        SFX.SetFloat("SFX", Mathf.Log10(sfxVolume) * 20);
        PlayerPrefs.SetFloat("effectVolume", sfxVolume);
        PlayerPrefs.Save();
    }

    public void LoadSFXVolume()
    {
        SFXslider.value = PlayerPrefs.GetFloat("effectVolume");
        SetSFXVolume();
    }
}
