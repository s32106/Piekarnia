using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Collectible : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        
        //Inventory playerInventory = null;
        //playerInventory = collision.gameObject.GetComponent<Inventory>();
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            //Inventory.instance.Increasecollectible(value);
        }

    }
}
