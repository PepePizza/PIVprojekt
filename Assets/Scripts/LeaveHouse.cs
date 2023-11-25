using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveHouse : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {

    if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.collider.gameObject.tag == "door")
                {
                    SceneManager.LoadScene(0);
                }
            }
        }

    }
}
