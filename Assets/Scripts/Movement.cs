using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float movementspeed = 5f;

    public AudioSource WalkingSound;

    private bool isMoving = false;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += move * Time.deltaTime * movementspeed;

        if (move != Vector3.zero)
        {
            transform.forward = move;
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        
        if (isMoving)
        {
            if (!WalkingSound.isPlaying)
            {
                WalkingSound.Play();
            }
        }
        else
        {
            WalkingSound.Stop();
        }
    }
}
