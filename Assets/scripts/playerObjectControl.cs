using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerObjectControl : MonoBehaviour
{
    private float turnRate = 100f;
	private float moveRate = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * turnRate * Input.GetAxis("Horizontal") * Time.deltaTime);
		transform.Translate(0f, 0f, moveRate * Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
