using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float duration = 2.0f; // the time it takes to move from bottom to top
    [SerializeField] private float elapsedTime = 0.0f; // the time elapsed since the movement started
    [SerializeField] private Vector3 startPosition; // the starting position of the object
    [SerializeField] private Vector3 endPosition; // the ending position of the object
    private bool isMovingUp = true; // flag to track the direction of movement

    void Start()
    {
        // save the starting position of the object
        startPosition = transform.position;

        // calculate the ending position of the object
        endPosition = new Vector3(startPosition.x, startPosition.y + 2.0f, startPosition.z);
    }

    void Update()
    {
        // increment the elapsed time
        elapsedTime += Time.deltaTime;

        // calculate the current position of the object
        if (isMovingUp)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / duration);
        }
        else
        {
            transform.position = Vector3.Lerp(endPosition, startPosition, elapsedTime / duration);
        }

        // check if the object has reached the end position
        if (transform.position == endPosition)
        {
            elapsedTime = 0.0f;
            isMovingUp = false;
        }
        // check if the object has reached the start position
        else if (transform.position == startPosition)
        {
            elapsedTime = 0.0f;
            isMovingUp = true;
        }
    }
}