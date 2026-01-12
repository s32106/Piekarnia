using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera MainCam;
    public Camera StartCam;
    public Camera RecipeCam;

    private void Start()
    {
        StartCam.gameObject.SetActive(true);
        MainCam.gameObject.SetActive(false);
        RecipeCam.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCam.gameObject.SetActive(false);
            MainCam.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R) && MainCam.isActiveAndEnabled)
        { 
            RecipeCam.gameObject.SetActive(true);
            MainCam.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            RecipeCam.gameObject.SetActive(false);
            MainCam.gameObject.SetActive(true);
        }
    }
}
