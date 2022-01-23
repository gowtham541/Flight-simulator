using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftScript : MonoBehaviour
{
    public float speed;
    private float maxSpeed;
    public float speedGain;
    public float BrakePower;
    public float rotSpeed;
    public float grav;
    
    private Rigidbody myRigid;
    public  float tailSpeed;
   

   

    

    void Start()
    {
        maxSpeed = 150;
        myRigid = GetComponent<Rigidbody>();

    }


    
    void Update()
    {

        AircraftMovement();
       
    }

  
    void AircraftMovement()
    {
      transform.position += transform.forward * speed * Time.deltaTime;
        speed -= transform.forward.y*grav * Time.deltaTime;



        if (Input.GetKey(KeyCode.Space))
        {
          if(speed < maxSpeed)
            {
                speed += speedGain * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (speed > 0)
            {
                speed -= BrakePower * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
          transform.Rotate(Vector3.right *rotSpeed * Time.deltaTime);    
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-Vector3.right * rotSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-Vector3.up * tailSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate( Vector3.up * tailSpeed * Time.deltaTime);
        }
    }




}
