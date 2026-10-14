
using UnityEngine;

public class BarrelReset : MonoBehaviour
{
    public Transform endPoint;
    public float resetDistance = 1f;

    private Vector3 startPosition;
    private Quaternion startRotation;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Save the barrel's starting position
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void FixedUpdate()
    {
        if (endPoint == null) return;

        // Check if barrel reached the end
        float distance = Vector3.Distance(
            transform.position,
            endPoint.position
        );

        if (distance <= resetDistance)
        {
            ResetBarrel();
        }
    }

    void ResetBarrel()
    {
        // Stop the barrel completely
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Return to starting position
        rb.position = startPosition;
        rb.rotation = startRotation;
    }
}
