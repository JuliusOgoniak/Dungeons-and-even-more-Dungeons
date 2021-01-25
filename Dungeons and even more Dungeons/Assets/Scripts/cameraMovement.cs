using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    public Vector3 targetOffset;
    [SerializeField]
    private float smoothness;

    void Start()
    {
        transform.position = target.position + targetOffset;
    }

    void Update()
    {
        
            transform.position = Vector3.Slerp(transform.position, target.position + targetOffset, smoothness * Time.fixedDeltaTime);
            //Vector3 newPos = target.position;
            //transform.position = Vector3.Slerp(transform.position, newPos + targetOffset , smoothness);
        
    }
}
