using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedItems : MonoBehaviour
{
    public static int ItemsFound = 0;

        void Awake()
    {
        // Don't destroy when loading new scene
        DontDestroyOnLoad(this.gameObject);

        GameObject[] ItemManagerObj = GameObject.FindGameObjectsWithTag("itemManagertag");
        
        if (ItemManagerObj.Length > 1)
        {
           Destroy(this.gameObject);
        }

        //Don't destroy when loading new scene
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (ItemsFound >= 3)
        {
            if (GameObject.Find("CauldronCanvas") != null)
            {
            GameObject.Find("CauldronCanvas").transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
            }
        }
    }
}
