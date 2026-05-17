using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Game_Music_Script : MonoBehaviour
{
    public AudioMixer gamemusic;

    public Slider gamemusicslider;

    void Start()
    {
        gamemusicslider.value = PlayerPrefs.GetFloat("slidervalue");
    }

    void Update()
    {

    }

    public void GameMusicDegeri(float volume)
    {
        gamemusic.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("slidervalue",gamemusicslider.value);
    }
}
