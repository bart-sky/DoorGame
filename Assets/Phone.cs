using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public AudioClip phoneRingTone;
    public AudioClip popUpSound;
    public AudioClip angryPhoneCall;
    public AudioClip happyPhoneCall;
    private static AudioSource audio;

    public Transform cam;

    public float offset;

    public Transform phoneSnap;
    public enum MessageType {Angry, Neutral, Happy}

    public MessageType currentMessageType = MessageType.Neutral;
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
    }

    public void PlayMessageSound()
    {
        audio.Stop();
        audio.PlayOneShot(popUpSound);
        switch (currentMessageType )
        {
            case MessageType.Angry:
                audio.PlayOneShot(angryPhoneCall); 
                break;
            case MessageType.Happy:
                //audio.PlayOneShot(happyPhoneCall); 
                break;
        }



    }
}
