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
        for (int i=0; i < 5; i++) {
            var position = new Vector3(Random.Range(parent.localScale.x * 0.5, parent.localScale.x * -0.5), 0, Random.Range(parent.localScale.z * 0.5, parent.localScale.z * -0.5));
            var gb = Instantiate (myPrefab, position, Quaternion.identity);
            gb.localPosition = position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        myPrefab.RotateAround(myPrefab.position, Vector3.up, rotationRate * Time.deltaTime);
    }
}
