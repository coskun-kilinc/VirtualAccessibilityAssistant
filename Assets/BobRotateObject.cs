using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobRotateObject : MonoBehaviour
{
    public float bobSpeed = 1f; // Speed at which the object bobs up and down
    public float bobHeight = 0.5f; // Height of the bobbing motion
    public float rotateSpeed = 30f; // Speed at which the object rotates
    private Vector3 startPosition; // Initial position of the object

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        // Bobbing motion
        Vector3 bobPosition = startPosition + Vector3.up * Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        transform.position = bobPosition;

        // Rotating motion
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}

