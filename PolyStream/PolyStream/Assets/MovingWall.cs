using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    
    public float sidewaysForce = 50f;
    public float movementRange = 7f;
    public Transform wall;
    public Rigidbody rb;
    float returnPos;
    Vector3 pos;


    private void Start()
    {
        pos = transform.position;
        returnPos = pos.x - movementRange;
    }

    void FixedUpdate()
    {
        Vector3 wallPos = wall.transform.position;
        if (wall.position.x <= returnPos)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (wall.position.x >= returnPos)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
