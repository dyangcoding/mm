using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraControl : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = Vector3.zero;
        Vector3 forward = target.transform.forward * 20.0f;
        Vector3 needPos = target.transform.position - forward;

        transform.position = Vector3.SmoothDamp(transform.position, needPos, ref velocity, 0.05f);
        transform.LookAt(target.transform);
        transform.rotation = target.transform.rotation;
    }
}
