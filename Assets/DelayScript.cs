
using UnityEngine;
using System.Collections;

public class BarrelDelay : MonoBehaviour
{
    public float startDelay = 0f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        // Stop barrel from moving immediately
        rb.isKinematic = true;
        rb.useGravity = false;
    }

    IEnumerator Start()
    {
        // Wait before rolling
        yield return new WaitForSeconds(startDelay);

        // Start rolling
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
