using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour {
    //CHA2 - Milda Petrikaitė IFF-6/5

    public bool inventory; //if true, can be stored in inventory
    public bool isInInventory = false; //if true, item is currently in inventory

    public void DoInteraction()
    {
        //picked up and put in inventory
        gameObject.SetActive(false);
        isInInventory = true;
    }
}
