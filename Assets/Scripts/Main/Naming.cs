using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Naming : MonoBehaviour
{
    public Text nameTxt;

    void Start()
    {
        nameTxt.text = DataManager.instance.playerName;
    }

}
