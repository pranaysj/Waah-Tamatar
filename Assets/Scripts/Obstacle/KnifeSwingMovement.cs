using UnityEngine;

public class SwingMovement : MonoBehaviour
{
    public float duration = 2.0f; // the time it takes to swing from one side to the other
    [SerializeField] private float elapsedTime = 0.0f; // the time elapsed since the movement started
    private bool isSwingingRight = true; // flag to track the direction of swing

    float swingAngle = 30.0f;

    Quaternion startRotation;
    Quaternion endRotation;

    void Start()
    {
        // initialize the rotation
        startRotation = Quaternion.Euler(0, 0, -swingAngle);
        endRotation = Quaternion.Euler(0, 0, swingAngle);
        transform.rotation = startRotation;
    }

    void Update()
    {
        // increment the elapsed time
        elapsedTime += Time.deltaTime;

        // calculate the current rotation of the object
        if (isSwingingRight)
        {
            transform.rotation = Quaternion.Lerp(startRotation, endRotation, elapsedTime / duration);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(endRotation, startRotation, elapsedTime / duration);
        }

        // check if the object has reached the end of the swing
        if (transform.rotation == endRotation)
        {
            elapsedTime = 0.0f;
            isSwingingRight = false;
        }
        // check if the object has reached the start of the swing
        else if (transform.rotation == startRotation)
        {
            elapsedTime = 0.0f;
            isSwingingRight = true;
        }
    }
}