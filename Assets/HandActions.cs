using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandActions : MonoBehaviour
{
    private int itemHeld = 1;
    private Door door;
    
    // Start is called before the first frame update
    void Start()
    {
        door = FindObjectOfType<Door>();
    }


    void OnTriggerEnter(Collider collision)
    {
        var door = collision.gameObject.GetComponent<Door>();
        if (door != null)
        {
            Knock();
        }
    }
    public void Knock()
    {
        door.Knock();
    }
}
