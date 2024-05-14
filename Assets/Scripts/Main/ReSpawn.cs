using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject[] charPrefabs;
    // public GameObject character;

    void Start()
    {
        DataManager.instance.player = Instantiate(charPrefabs[(int)DataManager.instance.currentCharacter]);
        DataManager.instance.player.transform.position = transform.position;
    }
}
