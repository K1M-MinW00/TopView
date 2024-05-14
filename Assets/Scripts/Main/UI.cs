using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UI : JoinBtn
{
    public GameObject Target;
    public Text nameTxt;
    public GameObject panel;
    public Button ChangeName;
    

    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        nameTxt = Target.GetComponentInChildren<Text>();
    }

    public void ClickRenaming()
    {
        panel.SetActive(true);
        DataManager.instance.player.GetComponent<Movement>().enabled = false;
        DataManager.instance.player.GetComponent<Animator>().enabled = false;
    }
    public void ClickAccpet()
    {
        panel.SetActive(false);
        DataManager.instance.player.GetComponent<Movement>().enabled = true;
        DataManager.instance.player.GetComponent<Animator>().enabled = true;
        nameTxt.text = DataManager.instance.playerName;
    }

}
