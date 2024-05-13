using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    private Controller controller;

    private void Awake()
    {
        controller = GetComponent<Controller>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        Rotate(direction);
    }

    private void Rotate(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotz) > 90f;
    }
}
