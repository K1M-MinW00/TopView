using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Target; // 카메라가 따라다닐 목표
    public float speed = 4.0f;
    public float z = -10f;

    Transform this_transform;
    Transform target_transform;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        this_transform = GetComponent<Transform>();
        target_transform = Target.GetComponent<Transform>();
    }

    void Update()
    {
        this_transform.position = Vector2.Lerp(this_transform.position, target_transform.position, speed * Time.deltaTime);
        this_transform.Translate(0, 0, z);
    }
}
