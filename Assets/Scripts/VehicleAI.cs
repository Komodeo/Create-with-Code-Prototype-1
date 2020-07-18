using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleAI : MonoBehaviour
{

    private float aiVehicleSpeed = 11f;
    public float minDistance = 31f;
    public float maxDistance = 65f;
    private bool aiVehicleMovingForward = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // change direction of vehicle based on distance
        if (transform.position.z < minDistance)
        {
            aiVehicleMovingForward = false;
        }

        if (transform.position.z > maxDistance)
        {
            aiVehicleMovingForward = true;
        }

        // make vehicle move forward or back
        if (aiVehicleMovingForward == true)
        {
            transform.Translate(Vector3.forward * aiVehicleSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.back * aiVehicleSpeed * Time.deltaTime);
        }
        

    }
}
