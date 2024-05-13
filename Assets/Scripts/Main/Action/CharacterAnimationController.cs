using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private readonly float magnitudeThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnitudeThreshold);
    }
}
