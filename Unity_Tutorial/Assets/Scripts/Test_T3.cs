﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_T3 : MonoBehaviour
{

    private Rigidbody myRigid;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //myRigid.maxAngularVelocity = 100;
            //myRigid.angularVelocity = Vector3.right * 100;

            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation));

            //myRigid.AddForce(Vector3.forward);
            //myRigid.AddTorque(Vector3.up);

            myRigid.AddExplosionForce(10, this.transform.right, 10);
        }
    }
}
