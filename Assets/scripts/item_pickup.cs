﻿
using UnityEngine;

public class item_pickup : interactable
{
    public override void Interact()
    {
        base.Interact();

        Pickup();
    }

    void Pickup()
    {
        Debug.Log("interacting");
        Destroy(gameObject);
    }
}
