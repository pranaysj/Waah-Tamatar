using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public new Transform camera; // Assign the camera's transform in the Inspector
    public float parallaxSpeed = 0.1f; // Adjust the parallax speed

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void LateUpdate()
    {
        float offsetX = camera.position.x * parallaxSpeed;
        transform.position = new Vector3(startPosition.x + offsetX, transform.position.y, transform.position.z);
    }
}