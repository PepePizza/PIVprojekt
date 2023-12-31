using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LeaveHouse : MonoBehaviour
{
    public GameObject indoorScene;
    public GameObject bokkcanvas;
    public GameObject mapCanvas;
    public GameObject cauldronCanvas;

    // Update is called once per frame
    void Update()
    {

    if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f) && !EventSystem.current.IsPointerOverGameObject())
            {
            Debug.Log("Hit object tag: " + hit.collider.gameObject.tag);

                if(hit.collider.gameObject.tag == "door")
                {
                    SceneManager.LoadScene(0);
                }
                if (hit.collider.gameObject.tag == "bookopen") 
                {
                    bokkcanvas.SetActive(true);
                }
                if (hit.collider.gameObject.tag == "map") 
                {
                    mapCanvas.SetActive(true);
                }
                if (hit.collider.gameObject.tag == "boat") 
                {
                    SceneManager.LoadScene(0);
                }
                if (hit.collider.gameObject.tag == "cauldron") 
                {
                    cauldronCanvas.SetActive(true);
                }
            }
        }
    }

}
