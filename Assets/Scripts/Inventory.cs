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

    void Start()
    {
        //collectibleText.text = "Fruits: " + currentCollectible.ToString();
    }

    public void Increasecollectible(int v)
    {
        currentCollectible += v;
        //collectibleText.text = "Fruits: " + currentCollectible.ToString();
    }
}
