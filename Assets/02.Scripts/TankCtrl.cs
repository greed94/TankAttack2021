using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCtrl : MonoBehaviour
{
    private Transform tr;
    public float speed = 10.0f;

    void Start()
    {
        tr = GetComponent<Transform>();    
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0, -5.0f, 0);
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        tr.Translate(Vector3.forward * Time.deltaTime * speed * v);
        tr.Rotate(Vector3.up * Time.deltaTime * 100.0f * h);
    }
}
