using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using System.Net;

public class SMSSystem : MonoBehaviour
{
    public InputField MobileNo;
    public InputField MainMessage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SndMessage()
    {
        Debug.Log("發送中");

        string numbers = MobileNo.text;
        string message = MainMessage.text;

        if(numbers == "")
        {
            Debug.Log("輸入電話好嗎？");
        }
        else if(message == "")
        {
            Debug.Log("輸入訊息好嗎？");
        }
        else if(numbers != "" && message != "")
        {
            //string url = "sms:" + numbers + "&body=" + WWW.EscapeURL(message);

            Application.OpenURL(string.Format("sms:" + numbers + "?body=" + message));

            Debug.Log("發送囉");
        }
    }
}
