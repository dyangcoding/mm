using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerObjectControl : MonoBehaviour
{
    private float speed = 10f;

    public float angle = .1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void Update () {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        angle += horizontalInput * Time.deltaTime;

        Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));

        transform.Translate(targetDirection * verticalInput * speed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(targetDirection);
	}
}
