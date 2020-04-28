using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;
    public bool RotateAroundPlayer = true;
    public float RotateSpeed = 5.0f;

    void Start()
    {
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        if (RotateAroundPlayer)
        {
            Quaternion turnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotateSpeed, Vector3.up);
            offset = turnAngle * offset;
        }
        Vector3 newpos = player.position + offset;
        transform.position = Vector3.Slerp(transform.position, newpos, SmoothFactor);
        if(LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(player);
    }
}
