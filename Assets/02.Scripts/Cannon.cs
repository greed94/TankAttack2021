using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float speed = 1000.0f;
    public GameObject sparkEffect;
    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * speed);
    }
    
    void OnCollisionEnter(Collision coll)
    {
        GameObject spark = Instantiate(sparkEffect,
                                       transform.position,
                                       Quaternion.identity);
        Destroy(spark, 3.0f);
    }
}
