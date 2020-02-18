using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System;
using System.IO;
using TMPro;

public class GetWeather : MonoBehaviour
{
    float counter = 0f;
    // weatherdata = "Waiting for weather..";
    public float tempK = 0f;

    // Start is called before the first frame update
    void Start()
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(String.Format("https://a6z15rkta7.execute-api.us-east-1.amazonaws.com/weather"));
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader sreader = new StreamReader(res.GetResponseStream());
        string jsonString = sreader.ReadToEnd();
        WeatherData info = JsonUtility.FromJson<WeatherData>(jsonString);
        //Debug.Log(jsonString);
        //Debug.Log(info.weather[0].main);
        //Debug.Log(info.main.temp);
        try
        {
            Debug.Log(info.main.temp);
            tempK = info.main.temp;
            //var temp = Math.Round(((info.main.temp - 273.15) * 9 / 5) + 32);
            //weatherdata = "Temperature " + temp + " F";
        }
        catch (Exception e)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > 60) {
            counter -= 60;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(String.Format("https://a6z15rkta7.execute-api.us-east-1.amazonaws.com/weather"));
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader sreader = new StreamReader(res.GetResponseStream());
            string jsonString = sreader.ReadToEnd();
            WeatherData info = JsonUtility.FromJson<WeatherData>(jsonString);
            //Debug.Log(jsonString);
            //Debug.Log(info.weather[0].main);
            //Debug.Log(info.main.temp);
            try
            {
                tempK = info.main.temp;
                //var temp = Math.Round(((info.main.temp - 273.15) * 9 / 5) + 32);
                //weatherdata = "Temperature " + temp + " F";
            }
            catch (Exception e)
            {

            }
        }
        //gameObject.GetComponent<TextMeshProUGUI>().text = weatherdata;
    }
}

[Serializable]
public class MainType
{
    public float temp;
    public float feels_like;
}

[Serializable]
public class WeatherType
{
    public string main;
    public string description;
}

[Serializable]
public class WeatherData
{
    public MainType main;
    public List<WeatherType> weather;
}