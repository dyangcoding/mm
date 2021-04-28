using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameObject : MonoBehaviour
{
    /*
    public GameObject go;
    public Transform myPrefab;
    public float xAngle, yAngle, zAngle;

    // Start is called before the first frame update
    void Start()
    {
        /*
        for (int i=0; i < 5; i++) {
            var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            Instantiate (myPrefab, position, Quaternion.identity);
        }
        
        Instantiate(go, new Vector3(0, 5f, 0), Quaternion.identity);
    }

    void Awake() {
        go.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        go.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }
    */
    public float xAngle, yAngle, zAngle;

    private GameObject cube1, cube2;

    void Awake()
    {
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
        cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        cube1.GetComponent<Renderer>().material.color = Color.red;
        cube1.name = "Self";

        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(-0.75f, 0.0f, 0.0f);
        cube2.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);
        cube2.GetComponent<Renderer>().material.color = Color.green;
        cube2.name = "World";
    }

    void Update()
    {
        cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        cube2.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }
}
