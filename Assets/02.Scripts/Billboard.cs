using UnityEngine;


public class Billboard : MonoBehaviour
{
    private Transform camTr;

    void Start()
    {
        camTr = Camera.main.transform;    
    }

    void Update()
    {
        transform.LookAt(camTr.position);
    }
}
