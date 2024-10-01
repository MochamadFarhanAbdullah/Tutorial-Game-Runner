using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Player sebagai target
    public Vector3 offset; // Offset dari posisi Player

    void Update()
    {
        // Atur posisi kamera agar mengikuti Player dengan offset yang telah ditentukan
        transform.position = target.position + offset;
    }

}
