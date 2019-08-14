using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playSound : MonoBehaviour {

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void play()
    {
        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }
    }
    public void goToVR()
    {
         SceneManager.LoadScene("House_on_the_lake_scene");
    }
}