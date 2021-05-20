using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameObjects : MonoBehaviour
{
    public Transform parent;
    public Transform myPrefab;
    private float rotationRate = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, transform.position, Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {
        myPrefab.RotateAround(myPrefab.position, Vector3.up, rotationRate * Time.deltaTime);
    }
}
