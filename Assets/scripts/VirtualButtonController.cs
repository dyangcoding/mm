using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonController : MonoBehaviour
{
    public GameObject area;
    public GameObject player;

    private bool moveFrontBtnPressed = false;
    private bool moveBackBtnPressed = false;
    private bool rotateLeftBtnPressed = false;
    private bool rotateRightBtnPressed = false;

    private float speed = 90;
    float yRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.moveFrontBtnPressed)
        {
            player.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (this.moveBackBtnPressed)
        {
            player.transform.Translate(Vector3.back * Time.deltaTime);
        }
        if (this.rotateLeftBtnPressed)
        {
            yRotation += Time.deltaTime * speed;
            player.transform.rotation = Quaternion.Euler(0, yRotation, 0);
        }
        if (this.rotateRightBtnPressed)
        {
            yRotation -= Time.deltaTime * speed;
            player.transform.rotation = Quaternion.Euler(0, yRotation, 0);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
        switch (vb.VirtualButtonName)
        {
            case "moveFrontBtn":
                this.moveFrontBtnPressed = true;
                break;
            case "moveBackBtn":
                this.moveBackBtnPressed = true;
                break;
            case "rotateLeftBtn":
                this.rotateLeftBtnPressed = true;
                break;
            case "rotateRightBtn":
                this.rotateRightBtnPressed = true;
                break;
        }
    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
        switch (vb.VirtualButtonName)
        {
            case "moveFrontBtn":
                this.moveFrontBtnPressed = false;
                break;
            case "moveBackBtn":
                this.moveBackBtnPressed = false;
                break;
            case "rotateLeftBtn":
                this.rotateLeftBtnPressed = false;
                break;
            case "rotateRightBtn":
                this.rotateRightBtnPressed = false;
                break;
        }
    }

}
