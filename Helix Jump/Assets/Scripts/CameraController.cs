using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform ball;
    [SerializeField] private float smoothSpeed;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - ball.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position, smoothSpeed);
        transform.position = newPos;
    }
}
