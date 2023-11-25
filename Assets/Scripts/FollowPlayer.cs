using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform cameraPosition;

    void update()
    {
        transform.position = cameraPosition.position;
    }
}
