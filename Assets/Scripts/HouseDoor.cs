using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseDoor : MonoBehaviour
{
    public AudioSource door;

    void OnTriggerEnter(Collider other){
        if (other.tag == "door"){
            SceneManager.LoadScene(1);
            door.Play();
        }
    }

}
