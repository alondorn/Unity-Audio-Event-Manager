using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sFXAudioSource;
    [SerializeField] AudioEventsManager _audioManager;
   

    private void Awake()
    {
        _audioManager.InitializeSounds(sFXAudioSource);
    }


   


    private void OnDisable()
    {
        _audioManager.Dispose();
        _audioManager = null;
    }
}
