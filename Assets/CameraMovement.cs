
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float distance = 6f;
    public float height = 3f;
    public float smoothSpeed = 8f;

    void LateUpdate()
    {
        if (player == null) return;

        // Stay behind and above the player
        Vector3 targetPosition = player.position
            + new Vector3(0, height, -distance);

        // Smoothly follow the player
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );

        // Always look at the player
        transform.LookAt(player.position + Vector3.up);
    }
}
