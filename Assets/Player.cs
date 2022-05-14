using System.Collections;
using System.Collections.Generic;
using BrokenVector.LowPolyFencePack;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Item.ObjectType itemHeld ;
    public Item.ObjectType CheckPlayerItem()
    {
        return itemHeld;
    }


    public void SetPlayerItem(Item.ObjectType item)
    {
        itemHeld= item;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) FindObjectOfType<HandActions>().Knock();
    }
}
