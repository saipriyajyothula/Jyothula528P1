using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationTeleport : MonoBehaviour
{
    public GameObject L1;
    public GameObject L2;
    public GameObject L3;
    public GameObject L4;
    public GameObject cameraObject;

    // Start is called before the first frame update
    GameObject cave2player;

    void Start()
    {
        cave2player = GameObject.Find("CAVE2-PlayerController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToL1()
	{
        //var temp = transform.position;
        //temp.x = L1.transform.position.x;
        //temp.z = L1.transform.position.z;
        //transform.position = temp;
        //transform.position = L1.transform.position;
        cave2player.GetComponent<CAVE2WandNavigator>().SetPosition(L1.transform.position);
        fadeCamera();
    }

    public void goToL2()
    {
        //transform.position = L2.transform.position;
        cave2player.GetComponent<CAVE2WandNavigator>().SetPosition(L2.transform.position);
        fadeCamera();
    }

    public void goToL3()
    {
        //transform.position = L3.transform.position;
        cave2player.GetComponent<CAVE2WandNavigator>().SetPosition(L3.transform.position);
        fadeCamera();
    }

    public void goToL4()
    {
        //transform.position = L4.transform.position;
        cave2player.GetComponent<CAVE2WandNavigator>().SetPosition(L4.transform.position);
        fadeCamera();
    }

    public void fadeCamera()
    {
        GetComponent<AudioSource>().Play();
        cameraObject.GetComponent<TeleportCameraFade>().fade = true;
        //cameraObject.GetComponent<TeleportCameraFade>().beginFade = true;
    }
}
