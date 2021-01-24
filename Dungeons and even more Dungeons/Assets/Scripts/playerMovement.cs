using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    void Update()
    {
     //player walk
     float _horizontal = Input.GetAxis("Horizontal") * movementSpeed;
     float _vertical = Input.GetAxis("Vertical") * movementSpeed;

     Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
     transform.Translate(_movement*Time.deltaTime,Space.World);

        //weapon aim
        RaycastHit _hit;
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(_ray,out _hit))
        {
            transform.LookAt(new Vector3(_hit.point.x, transform.position.y, _hit.point.z));
        }
    }
}
