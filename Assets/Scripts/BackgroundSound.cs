using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("music");
        
        //Only play the audio once
        if (musicObj.Length > 1)
        {
           Destroy(this.gameObject);
        }

        //Don't destroy when loading new scene
        DontDestroyOnLoad(this.gameObject);
    }
}
