
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 4f;
    public float moveSpeed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.Sin(
            Time.time * moveSpeed
        ) * moveDistance;

        transform.position = startPosition
            + Vector3.forward * movement;
    }
}
