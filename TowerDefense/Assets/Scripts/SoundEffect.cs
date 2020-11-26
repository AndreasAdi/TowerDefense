using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SoundEffect : MonoBehaviour
{
    public AudioClip[] soundEff; 
    AudioSource audio;

    // Start is called before the first frame update
    void Awake()
    {   audio = gameObject.AddComponent(typeof(AudioSource)) as AudioSource; }

    public void playSound(int i, bool loop,float volume)
    {   audio.Stop();
        if (loop == true)
        {
            audio.volume = volume;
            audio.clip = soundEff[i];
            audio.loop = true;
            audio.Play();
        }
        else
        { audio.PlayOneShot(soundEff[i]); }
    }
    public void stopSound()
    {
        audio.Stop();
    }
}
