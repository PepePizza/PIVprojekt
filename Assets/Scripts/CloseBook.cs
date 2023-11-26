using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBook : MonoBehaviour
{
    public GameObject openbookcanvas;

    public void closethebook()
    {
        if (openbookcanvas.activeInHierarchy == false)
        {
            openbookcanvas.SetActive(true);
        }
        else
        {
            openbookcanvas.SetActive(false);
        }
    }
}
