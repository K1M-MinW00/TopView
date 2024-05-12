using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinBtn : MonoBehaviour
{
    public Button joinBtn;
    public InputField playerNameInput;
    public string playerName;

    void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
        joinBtn = GetComponentInChildren<Button>();
    }

    private void Start()
    {
        joinBtn.interactable = false;
    }

    public void Check()
    {
        // Debug.Log("Check");

        if (playerNameInput.text.Length < 2 || playerNameInput.text.Length > 10)
        {
            joinBtn.interactable = false;
        }
        else
        {
            playerName = playerNameInput.text;
            DataManager.instance.playerName = playerName;
            joinBtn.interactable = true;
        }
    }
}
