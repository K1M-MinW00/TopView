using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public enum Character
{
    Black, Blue
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public string playerName;
    public Character currentCharacter;

    public GameObject player;
    private void Awake()
    {
        if (instance == null) instance = this;
        else
            return;
        DontDestroyOnLoad(gameObject);
    }

    public void ClickJoinBtn()
    {
        SceneManager.LoadScene("MainScene");
    }
}
