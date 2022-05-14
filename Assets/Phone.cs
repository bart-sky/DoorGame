using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public AudioClip phoneRingTone;
    public AudioClip popUpSound;
    public AudioClip angryPhoneCall;
    private static AudioSource audio;

    public Transform cam;

    public float offset;

    public Transform phoneSnap;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        transform.position = phoneSnap.position;
    }
    

    public void Ring()
    {
        audio.clip = phoneRingTone;
        audio.Play();
        Invoke("PlayMessageSound",4);
    }

    public void PlayMessageSound()
    {
        audio.Stop();
        audio.PlayOneShot(popUpSound);
        audio.PlayOneShot(angryPhoneCall);
    }
}
