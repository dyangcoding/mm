using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerObjectControl : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 playerPos = new Vector3(0, 5f, 0);

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
		float xPos = transform.position.x + Input.GetAxis("Horizontal");
        float yPos = transform.position.y + Input.GetAxis("Vertical");
		playerPos = new Vector3 (xPos, yPos, 0);
		transform.position = playerPos;
	}
}
