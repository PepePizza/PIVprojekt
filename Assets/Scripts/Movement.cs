using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float movementspeed = 5f;

    public AudioSource WalkingSound;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += move * Time.deltaTime * movementspeed;

        if (move != Vector3.zero)
        {
            transform.forward = move;
            //WalkingSound.Play();
        }
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.D))
        {
            WalkingSound.enabled = true;
        }
        else
        {
            WalkingSound.enabled = false;
        }
    }
}
