using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if (other.tag == "door"){
            SceneManager.LoadScene(1);
        }
    }

}
