using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] soundEffect;

    public void Sound()
    {
        Debug.Log("���� ȣ��");
    }
}
