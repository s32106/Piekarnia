using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera MainCam;
    public Camera StartCam;
    public Camera RecipeCam;
    private Inventory inventory;

    private void Start()
    {
        StartCam.gameObject.SetActive(true);
        MainCam.gameObject.SetActive(false);
        RecipeCam.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && StartCam.isActiveAndEnabled)
        {
            StartCam.gameObject.SetActive(false);
            RecipeCam.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.X) && RecipeCam.isActiveAndEnabled)
        {
            RecipeCam.gameObject.SetActive(false);
            MainCam.gameObject.SetActive(true);
        }

        if (int Inventory.currentCollectible = 7)
        {
            RecipeCam.gameObject.SetActive(true);
            MainCam.gameObject.SetActive(false);
        }
    }
}
