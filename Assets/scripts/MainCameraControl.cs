using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraControl : MonoBehaviour
{
    public Transform target;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = target.transform.rotation;
    }

    void LateUpdate()
    {
        Vector3 offsetRotated = target.transform.rotation * offset;
        transform.position = target.transform.position + offsetRotated;
    }
}
