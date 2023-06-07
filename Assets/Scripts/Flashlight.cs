using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public bool onToggle = false;
    public GameObject lightSource;
    public AudioSource sound;
    public AudioClip clickSoundOn;
    public AudioClip clickSoundOff;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flashlight"))
        {
            onToggle = !onToggle;
            lightSource.SetActive(onToggle);
            if (onToggle)
            {
                sound.PlayOneShot(clickSoundOn);
            }
            else
            {
                sound.PlayOneShot(clickSoundOff);
            }
        } 
    }
}
