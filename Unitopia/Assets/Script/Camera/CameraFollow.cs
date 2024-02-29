using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.8f;
    public Vector2 minPosition;
    public Vector2 maxPosition;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Jogador").transform;
    }

    void FixedUpdate()
    {
        Vector3 startPosition = new Vector3(target.position.x, target.position.y, -1f);
        Vector3 smoothedPosition  = Vector3.Lerp(transform.position, startPosition, smoothSpeed * Time.fixedDeltaTime);
        transform.position = new Vector3(
            Mathf.Clamp(smoothedPosition.x, minPosition.x, maxPosition.x),
            Mathf.Clamp(smoothedPosition.y, minPosition.y, maxPosition.y),
            smoothedPosition.z
        );
    }
}
