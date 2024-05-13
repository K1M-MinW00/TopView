using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected Controller controller;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<Controller>();
    }
}
