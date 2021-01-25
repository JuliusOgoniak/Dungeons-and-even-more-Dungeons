using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    public float movementSpeed;
    Rigidbody rb;
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

     //player walk
        float _horizontal = Input.GetAxisRaw("Horizontal") * movementSpeed ;
        float _vertical = Input.GetAxisRaw("Vertical") * movementSpeed;
        
        rb.velocity = new Vector3(_horizontal,0,_vertical) * Time.fixedDeltaTime; 

        //weapon aim
        RaycastHit _hit;
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(_ray,out _hit))
        {
            transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));
        }
    }
}
