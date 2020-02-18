using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class SwitchTempUnits : MonoBehaviour
{
    bool isF = true;
    public GameObject tempText;
    public GameObject unitText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isF)
        {
            var temp = Math.Round(((tempText.GetComponent<GetWeather>().tempK - 273.15) * 9 / 5) + 32);
            tempText.GetComponent<TextMeshProUGUI>().text = "Temperature " + temp + " F";
            unitText.GetComponent<TextMeshProUGUI>().text = "Switch to C";
        }
        else
        {
            var temp = Math.Round(tempText.GetComponent<GetWeather>().tempK - 273.15);
            tempText.GetComponent<TextMeshProUGUI>().text = "Temperature " + temp + " C";
            unitText.GetComponent<TextMeshProUGUI>().text = "Switch to F";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
        isF = !isF;

        //if (tempText.GetComponent<GetWeather>().tempK == 0)
        //{
        //    tempText.GetComponent<TextMeshProUGUI>().text = "Waiting for weather..";
        //    if (isF)
        //    {
        //        unitText.GetComponent<TextMeshProUGUI>().text = "Switch to C";
        //    }
        //    else
        //    {
        //        unitText.GetComponent<TextMeshProUGUI>().text = "Switch to F";
        //    }
        //}

        
    }
}
