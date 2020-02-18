using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsplay : MonoBehaviour
{
    public GameObject spotlights;
    bool isMoving = false;
    int count = 0;
    bool isIncreasing = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            if (count <= 299 && isIncreasing)
            {
                count++;
            }
            else if (count == 300 && isIncreasing)
            {
                count--;
                isIncreasing = false;
            }
            else if (count >= 1 && !isIncreasing)
            {
                count--;
            }
            else if (count == 0 && !isIncreasing)
            {
                count++;
                isIncreasing = true;
            }


            for (int k = 0; k < spotlights.transform.childCount; k++)
            {
                spotlights.transform.GetChild(k).GetChild(0).gameObject.transform.localRotation = Quaternion.Euler((-30 - (count / 25) * 5), 0, 0);
            }
        }
        else
        {
            for (int k = 0; k < spotlights.transform.childCount; k++)
            {
                spotlights.transform.GetChild(k).GetChild(0).gameObject.transform.localRotation = Quaternion.Euler(-60, 0, 0);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isMoving = !isMoving;
    }
}
