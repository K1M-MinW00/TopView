using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateTime : MonoBehaviour
{
    private Text timeTxt;

    private void Awake()
    {
        timeTxt = transform.GetComponent<Text>();
    }

    void Update()
    {
        timeTxt.text = NowTime();
    }

    public static string NowTime()
    {
        return System.DateTime.Now.ToString("HH:mm");
    }
}
