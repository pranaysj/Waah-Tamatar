using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Assign the player's transform in the Inspector
    public float smoothSpeed = 0.3f; // Adjust the smoothness of the camera movement
    public float offsetValue = 2.0f;
    private Vector3 offset = new Vector3(4, 0, 0); // Offset from the player's position

    public Roll roll;



    private void LateUpdate()
    {
        switch (Math.Sign(roll.horizontalInput))
        {
            case 1:
                offset.x = offsetValue;
                break;
            case -1:
                offset.x = -offsetValue;
                break;
            default:
                // handle the case where horizontalInput is exactly 0, if needed
                break;
        }


        // Calculate the target position
        Vector3 targetPosition = new Vector3(player.position.x + offset.x, transform.position.y, transform.position.z);

        // Smoothly move the camera to the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}