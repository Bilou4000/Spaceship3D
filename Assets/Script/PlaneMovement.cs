using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField] private float speed, tilt, rotatingYSpeed, rotatingXSpeed;
    private Quaternion zQuater, yQuater;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            

            
        }
        if (Input.GetKey(KeyCode.D))
        {
            yQuater = new Quaternion(0, (transform.rotation.y + rotatingYSpeed) * Time.deltaTime, 0, 1);
            zQuater = new Quaternion(0, 0, (transform.rotation.z + tilt) * Time.deltaTime, -1);

            transform.rotation = yQuater * transform.rotation * zQuater;
        }

        if (Input.GetKey(KeyCode.A))
        {
            yQuater = new Quaternion(0, (transform.rotation.y + rotatingYSpeed) * Time.deltaTime, 0, -1);
            zQuater = new Quaternion(0, 0, (transform.rotation.z + tilt) * Time.deltaTime, 1);

            transform.rotation = yQuater * transform.rotation * zQuater;
        }


        //else
        //{
        //    transform.Rotate(-transform.rotation.x, -transform.rotation.y, -transform.rotation.z);
        //}
    }

}
