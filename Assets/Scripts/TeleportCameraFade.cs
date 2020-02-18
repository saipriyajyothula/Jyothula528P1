using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCameraFade : MonoBehaviour
{
    public bool fade;
    float fadeSpeed = 0.5f;
    public Texture blackTexture;
    float alphaFadeValue;

    // Start is called before the first frame update
    void Start()
    {
        fade = false;
        alphaFadeValue = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (fade)
        {
            alphaFadeValue -= Time.deltaTime * fadeSpeed;
            if (alphaFadeValue < 0)
            {
                alphaFadeValue = 0;
            }
        }
    }

    private void OnGUI()
    {
        if (fade)
        {
            GUI.color = new Color(0, 0, 0, alphaFadeValue);
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), blackTexture);
            if(alphaFadeValue == 0)
            {
                fade = false;
                alphaFadeValue = 1f;
            }
        }
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TeleportCameraFade : MonoBehaviour
//{
//    public bool fade;
//    public bool beginFade;
//    bool fadeIn;
//    float fadeSpeed = 1f;
//    public Texture blackTexture;
//    float alphaFadeValue;

//    // Start is called before the first frame update
//    void Start()
//    {
//        fade = false;
//        fadeIn = true;
//        alphaFadeValue = 0f;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (fade)
//        {
//            if (fadeIn)
//            {
//                beginFade = false;
//                alphaFadeValue += Time.deltaTime * fadeSpeed;
//                if (alphaFadeValue > 1)
//                {
//                    alphaFadeValue = 1;
//                    fadeIn = false;
//                }
//            }
//            else
//            {
//                alphaFadeValue -= Time.deltaTime * fadeSpeed;
//                if (alphaFadeValue < 0)
//                {
//                    alphaFadeValue = 0;
//                    fadeIn = true;
//                }
//            }
//            Debug.Log(alphaFadeValue);
//        }
//    }

//    private void OnGUI()
//    {
//        if (fade)
//        {
//            GUI.color = new Color(0, 0, 0, alphaFadeValue);
//            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), blackTexture);
//            if (alphaFadeValue == 0 && beginFade == false)
//            {
//                fade = false;
//            }
//        }
//    }
//}
