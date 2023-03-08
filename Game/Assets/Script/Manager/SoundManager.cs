using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] soundEffect;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Sound(int count)
    {
        audioSource.PlayOneShot(soundEffect[count]);
    }
}
