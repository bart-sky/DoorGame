using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ObjectType {Bone, MusicPlayer, Jewelry};
    
    public ObjectType objectType;

    public void SetItem()
    {
        FindObjectOfType<Player>().SetPlayerItem(objectType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
