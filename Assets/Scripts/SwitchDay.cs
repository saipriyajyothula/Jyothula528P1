using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDay : MonoBehaviour
{
    public GameObject[] hideObjects;
    public GameObject[] showObjects;
    public GameObject streetLights;
    public GameObject sceneObj;
    public AudioClip day; 
    public AudioClip night;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchDay(bool isDay)
    {
        for (int i = 0; i < hideObjects.Length; i++)
        {
            hideObjects[i].SetActive(!isDay);
        }
        for (int j = 0; j < showObjects.Length; j++)
        {
            showObjects[j].SetActive(isDay);
        }
        for (int k = 0; k < streetLights.transform.childCount; k++)
        {
            streetLights.transform.GetChild(k).GetChild(2).gameObject.SetActive(!isDay);
        }
        if (isDay)
        {
            sceneObj.GetComponent<AudioSource>().clip = day;
        }
        else
        {
            sceneObj.GetComponent<AudioSource>().clip = night;
        }
    }
}
