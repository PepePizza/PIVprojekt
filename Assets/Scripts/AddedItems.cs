using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddedItems : MonoBehaviour
{
    void Awake()
    {
        // Don't destroy when loading new scene
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log("Hit object tag: " + hit.collider.gameObject.tag);

                if (hit.collider.gameObject != null)
                {
                    if (hit.collider.gameObject.tag == "rosebundle" ||
                        hit.collider.gameObject.tag == "mushroom" ||
                        hit.collider.gameObject.tag == "cactus")
                    {
                        CollectedItems.ItemsFound++;
                        Debug.Log("Items Found: " + CollectedItems.ItemsFound);
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
    }
}




