using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    [SerializeField]private LayerMask cookieMask;
    public float cookieNumber = 0;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 100, cookieMask)) 
            {
                cookieNumber++;
            }
            else
            {
                Debug.Log("Did not hit");
            }
        }
    }
}
