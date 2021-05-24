using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameObjects : MonoBehaviour
{
    public Transform myPrefab;
    public Material tableMat;
    private float rotationRate = 50f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < 5; i++) {
            var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            var obj = Instantiate (myPrefab, position, Quaternion.identity);
            obj.GetComponent<Renderer>().material = tableMat;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        myPrefab.RotateAround(myPrefab.position, Vector3.up, rotationRate * Time.deltaTime);
    }
}
