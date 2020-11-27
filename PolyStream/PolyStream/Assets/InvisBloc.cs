using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisBloc : MonoBehaviour
{
    public float range = 10f;
    MeshRenderer rend;
    Transform bloc;

    private void Start()
    {
        bloc = GetComponent<Transform>();
        rend = GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        Vector3 blocPos = bloc.transform.position;
        int layerMask = 1 << 9;
        if (Physics.CheckSphere(blocPos, range, layerMask))
        {
            rend.enabled = true;
        }
        else
        {
            rend.enabled = false;
        }
    }
}
