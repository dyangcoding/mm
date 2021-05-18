using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonController : MonoBehaviour
{
    public GameObject area;
    public GameObject player;

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

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
        switch (vb.VirtualButtonName)
        {
            case "moveFrontBtn":
                player.transform.Translate(Vector3.forward * Time.deltaTime);
                break;
            case "moveBackBtn":
                player.transform.Translate(Vector3.back * Time.deltaTime);
                break;
            case "rotateLeftBtn":
                player.transform.Rotate(Vector3.up * Time.deltaTime);
                break;
            case "rotateRightBtn":
                player.transform.Rotate(Vector3.down * Time.deltaTime);
                break;
        }
    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
    }

}
