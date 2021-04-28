using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameObjects : MonoBehaviour
{
    public Transform myPrefab;
    private float rotationRate = 50f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < 5; i++) {
            var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            Instantiate (myPrefab, position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        myPrefab.RotateAround(myPrefab.position, Vector3.up, rotationRate * Time.deltaTime);
    }
}
