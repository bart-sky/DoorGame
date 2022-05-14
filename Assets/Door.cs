using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private LevelManager lvl;
    private Player player;
    public Item.ObjectType correctItem;
    private bool openning;
    private AudioSource doorAudio;

    public AudioClip knockSound;

    public AudioClip happyCustomer;
    public AudioClip sadCustomer;
    public AudioClip winSound;
    public AudioClip loseSound;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        doorAudio = GetComponent<AudioSource>();
        lvl = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        if(player ==null) player = FindObjectOfType<Player>();

        CheckItem(player.CheckPlayerItem());
    }

    private void CheckItem(Item.ObjectType item)
    {
        print("Checking our item " + item + " with door item " + correctItem);
        if (item == correctItem)
        {
            doorAudio.clip = happyCustomer;
            doorAudio.Play();
            print("You win");
            Invoke("WinLevel", 5f);

        }
        else
        {
            doorAudio.clip = sadCustomer;
            doorAudio.Play();
            Invoke("LoseLevel", 8f);
        }
    }

    void LoseLevel()
    {
        doorAudio.PlayOneShot(loseSound);

        lvl.LoseLevel();
    }    
    void WinLevel()
    {
        doorAudio.PlayOneShot(winSound);

        lvl.WinLevel();
    }
    
    public void SetDoor()
    {
        
        correctItem = (Item.ObjectType)Random.Range(0,  System.Enum.GetValues(typeof(Item.ObjectType)).Length);
        print("Door set to " + correctItem);
    }

    public void Knock()
    {
        doorAudio.clip = knockSound;
        doorAudio.Play();
        if (!openning)
        {
            openning = true;
            Invoke(nameof(Open),2f);
        }
    }
    
}
