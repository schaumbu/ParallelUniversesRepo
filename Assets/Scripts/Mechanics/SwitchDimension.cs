using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDimension : MonoBehaviour
{
    public GameObject dimension1;
    public GameObject dimension2;

    private bool inDimension1;

    private void Start()
    {
        inDimension1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (inDimension1)
            {
                dimension1.SetActive(false);
                dimension2.SetActive(true);
                inDimension1 = false;
            }
            else
            {
                dimension2.SetActive(false);
                dimension1.SetActive(true);
                inDimension1 = true;
            }
        }
    }
}
