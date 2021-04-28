using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube2 : MonoBehaviour
{
    public Transform myPrefab;
    public float rotationRate = 100f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(0, 5f, 0), Quaternion.Euler(90, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, rotationRate * Time.deltaTime);
    }
}
