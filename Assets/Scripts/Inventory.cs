using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    //public TMP_Text collectibleText;
    public int currentCollectible = 0;
    
    void Awake()
    {
        instance = this;
    }

    public void Increasecollectible(int v)
    {
        currentCollectible += v;
    }
}
