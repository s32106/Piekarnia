using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera MainCam;
    public Camera StartCam;
    public Camera RecipeCam;
    public Camera ComicCam0;
    public Camera ComicCam1;
    public Camera ComicCam2;
    public Camera ComicCam3;
    private Inventory inventory;

    private void Start()
    {
        StartCam.gameObject.SetActive(true);
        MainCam.gameObject.SetActive(false);
        RecipeCam.gameObject.SetActive(false);
        ComicCam0.gameObject.SetActive(false);
        ComicCam1.gameObject.SetActive(false);
        ComicCam2.gameObject.SetActive(false);
        ComicCam3.gameObject.SetActive(false);
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

        //if (int Inventory.currentCollectible = 7)
        if (Input.GetKeyDown(KeyCode.C) && MainCam.isActiveAndEnabled)
        {
            ComicCam0.gameObject.SetActive(true);
            MainCam.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E) && ComicCam0.isActiveAndEnabled)
        {
            ComicCam0.gameObject.SetActive(false);
            ComicCam1.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Q) && ComicCam1.isActiveAndEnabled)
        {
            ComicCam1.gameObject.SetActive(false);
            ComicCam2.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && ComicCam2.isActiveAndEnabled)
        {
            ComicCam2.gameObject.SetActive(false);
            ComicCam3.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Q) && ComicCam3.isActiveAndEnabled)
        {
            ComicCam3.gameObject.SetActive(false);
            MainCam.gameObject.SetActive(true);
        }
    }
}
