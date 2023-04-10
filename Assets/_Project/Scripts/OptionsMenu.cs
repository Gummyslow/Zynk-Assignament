using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public static OptionsMenu Instance { get; private set; }

    public AudioMixer my_mixer;

    public Toggle my_toggle;

    private void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }

    public void Display()
    {
        gameObject.SetActive(true);
    }

    public void MasterVolume(float slider_value)
    {
        //Am ales sa fac abordarea asta(conversie logaritmica) pentru ca mixerul are un parcurs logaritmic si cel al sliderului este liniar
        //Daca as fi facut dupa modul basic, daca dadeam sliderul de la maxim la jumatate, ar fi fost prea sensitive si as fi scazut prea mult
        my_mixer.SetFloat("MasterVolume", Mathf.Log10(slider_value) * 20); 
    }

    public void SlowMotionToggle(bool isOn)
    {
        if (isOn)
        {
            GameSystem.Instance.SlowMotionEffectOn();//enable slow-mo
        }
        else
        {
            GameSystem.Instance.SlowMotionEffectOff();//disable slo-mo
        }
    }

    public void Back()
    {
        UIAudioPlayer.PlayPositive();
        gameObject.SetActive(false);
        PauseMenu.Instance.Display();
    }
}
