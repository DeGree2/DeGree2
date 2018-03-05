using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {
    //CHA1 & CHA2 - Milda Petrikaitė IFF-6/5

    public GameObject currentInterObject = null; //current item in range
    public InteractionObject currentInterObjScript = null;
    public Inventory inventory;

    private void Update()
    {
        //if there is a current interactable object, picks it up to inventory
        if (Input.GetButtonDown("Interact") && currentInterObject)
        {
            //check to see if this object is to be stored in inventory
            if (currentInterObjScript.inventory && !currentInterObjScript.isInInventory)
            {
                inventory.AddItem(currentInterObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //when item is in range, it becomes current interactable object (can be picked up)
        if (other.CompareTag("interObject"))
        {
            //Debug.Log(other.name);
            currentInterObject = other.gameObject;
            currentInterObjScript = currentInterObject.GetComponent<InteractionObject>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //when item becomes out of range, it is not current interactable object anymore (can't pick up)
        if (other.CompareTag("interObject"))
        {
            if(other.gameObject == currentInterObject)
            {
                currentInterObject = null;
            }
        }
    }
}
