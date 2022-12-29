using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmSource;
    public AudioSource seSource;

    public AudioClip[] bgmList;
    public enum BGM
    {
        Main
    }
    public AudioClip[] seList;
    public enum SE
    {
        Get,
        Dial,
        Doar,
        Inshu,
        Slime,
        Out,
    }

    public static AudioManager instance;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        PlayBGM(BGM.Main);
    }

    public void PlayBGM(BGM bgm)
    {
        int index = (int)bgm;
        bgmSource.clip = bgmList[index]; //音をセットする
        bgmSource.Play();
    }

    public void playSE(SE se)
    {
        int index = (int)se;
        AudioClip clip = seList[index];
        seSource.PlayOneShot(clip);
    }
    

}
