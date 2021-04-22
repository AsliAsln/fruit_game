
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController:MonoBehaviour
{

    public GameObject target;
    public float distance;
    Vector3 pos;

    void Start()
    {
        pos = this.transform.position;
    }

    void LateUpdate()
    {
        
                                          
        pos.z= target.transform.position.z;
        //pos.y = Mathf.Lerp(pos.y, target.transform.position.y + height, Time.deltaTime);
        //pos.z = Mathf.Lerp(pos.z, target.transform.position.z - distance, Time.deltaTime);
        pos.z = target.transform.position.z - distance;
        transform.position = pos;
    }
}