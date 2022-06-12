using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(menuName = "ScriptableObjects/AudioEventsManager")]
public class AudioEventsManager : ScriptableObject
{
    [SerializeField] EventAudioElement[] eventAudioElements;

   

    public void InitializeSounds(AudioSource audioSource)
    {
        for (int i = 0; i < eventAudioElements.Length; i++)
        {
            AudioClip audioClip = eventAudioElements[i].sliceSound;
            Messanger.Subscribe(eventAudioElements[i].audioClipGameEvent, () =>
            {
                audioSource.clip = audioClip;
                audioSource.Play();
            }
            );
        }
    }

   
    public void Dispose()
    {
        eventAudioElements = null;
    }
}
