using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private bool altCamera = false;
    public Vector3 originalOffset = new Vector3(0, 5, -7);
    public Vector3 altOffset = new Vector3(0, 5, -10);
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = originalOffset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // offset camera behind player
        transform.position = player.transform.position + offset;

        // switch camera view on key press
        if (Input.GetButtonDown("Fire1"))
        {
            if (altCamera == false)
            {
                altCamera = true;
                offset = altOffset;
            }
            else
            {
                altCamera = false;
                offset = originalOffset;
            }
            
        }
    }
}
