using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBloc : MonoBehaviour
{
    public Transform bloc;
    public Rigidbody rb;
    public MovingBloc blocMovement;

    public float sidewaysForce;
    public float movementPos;
    public float endPos;
    float range = 10f;

    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
        endPos = pos.x - movementPos;
    }

    void FixedUpdate()
    {
        Vector3 blocPos = bloc.transform.position;
        int layerMask = 1 << 9;
        if (Physics.CheckSphere(blocPos, range, layerMask))
        {
            if (blocPos.x >= endPos)
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if (blocPos.x <= endPos)
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
                rb.AddForce(0, 0, 0, ForceMode.VelocityChange);
            }
        }

    }
}