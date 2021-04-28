using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerObjectControl : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 playerPos = new Vector3(0, 5f, 0);

	private float rotationRate = 5f;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void Update () {
		transform.RotateAround(transform.position, Vector3.up, rotationRate * Time.deltaTime);
	}
}
