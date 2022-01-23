using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
   
   public Vector3 offset;

    public bool lookAttarget = false;

    void Start()
    {
          offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = target.transform.position + offset;
        transform.position = newPosition;

        if(lookAttarget)
        {
            transform.LookAt(target);
        }

    }

}
