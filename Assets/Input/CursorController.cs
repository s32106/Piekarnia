using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CursorController : MonoBehaviour
{
    private Controls controls;

    private void DetectObject()
    {
        RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
        if (hits2D.collider != null)
            Debug.Log("Hit 2D Collider" + hits2D.collider.tag);
    }
}
