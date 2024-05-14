using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class SelectChar : MonoBehaviour
{
    public Character character;
    Animator anim;
    SpriteRenderer sr;

    public SelectChar[] chars;

    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        if (DataManager.instance.currentCharacter == character) OnSelect();
        else OnDeselect();
    }

    private void OnMouseUpAsButton()
    {
        DataManager.instance.currentCharacter = character;
        OnSelect();

        for (int i = 0; i < chars.Length; i++)
            if (chars[i] != this) chars[i].OnDeselect();
    }

    void OnSelect()
    {
        anim.SetBool("isWalking", true);
        sr.color = new Color(1f, 1f, 1f);
    }

    void OnDeselect()
    {
        anim.SetBool("isWalking", false);
        sr.color = new Color(1f, 1f, 1f,0.3f);
    }
}
