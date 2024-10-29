using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    public float shrinkScale = 0.5f;
    public float shrinkSpeed = 5.0f;

    private Vector3 originalScale;

    public bool isShrunk = false;
    private Vector3 endScale;

    public PhysicsMaterial2D boxMaterial;
    public Rigidbody2D boxRigidbody1;
    public Rigidbody2D boxRigidbody2;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {
            if (!isShrunk)
            {

                endScale = originalScale * shrinkScale;
                StartCoroutine(ShrinkAndExpand());
                boxMaterial.friction = 10;
                boxRigidbody1.mass = 100;
                boxRigidbody2.mass = 100;
                isShrunk = true;
            }
            else
            {
                endScale = originalScale;   
                StartCoroutine(ShrinkAndExpand());
                boxMaterial.friction = 1;
                boxRigidbody1.mass = 10;
                boxRigidbody2.mass = 10;
                isShrunk = false;
            }
        }
    }

    IEnumerator ShrinkAndExpand()
    {
        float timer = 0;
        Vector3 startScale = transform.localScale;

        while (timer < 1)
        {
            transform.localScale = Vector3.Lerp(startScale, endScale, timer);
            timer += Time.deltaTime * shrinkSpeed;
            yield return null;
        }

        transform.localScale = endScale;
    }

}
