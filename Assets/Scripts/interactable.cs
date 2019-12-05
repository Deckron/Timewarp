using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 script to act as a base class for all other interactable objects
     */
public class interactable : MonoBehaviour
{
    public float radius = 3f;       //interaction radius
    public Transform interactionTransform;      //transform in case of offset(?)

    //bool isFocus = false;       //being focused
    Transform player;       //reference to player transform
    bool hasInteracted = false; //has it been interacted

    public virtual void Interact()
    {
        Debug.Log("interacting with " + transform.name);
    }


    void Update()
    {
        if (!hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public void OnFocused(Transform playerTransform)
    {
        //isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void onDeFocusd()
    {
        //isFocus = false;
        player = null;
        hasInteracted = false;
    }

    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
        {
            interactionTransform = transform;
        }
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}
