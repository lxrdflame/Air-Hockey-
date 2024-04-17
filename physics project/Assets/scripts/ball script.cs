using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
    public countdown countdownScript;
    public Transform Center;

    private int contactcount = 0;
    private bool Playerhastouched = false;

    private float MinX = -2f;
    private float MaxX = 2f;

    private float MinY = -4f;
    private float MaxY = 4f;

    void Start()
    {
        countdownScript = FindObjectOfType<countdown>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (collision.collider.CompareTag("Goal"))
        {
            gameObject.transform.position = Center.position;
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
            }
        }

        if (collision.collider.CompareTag("Goal"))
        {
            if (countdownScript != null)
            {
                countdownScript.StartCoroutine(countdownScript.Countdown());
            }
        }

        if (collision.collider.CompareTag("Goal2"))
        {
            gameObject.transform.position = Center.position;
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
            }
        }

        if (collision.collider.CompareTag("Goal2"))
        {
            if (countdownScript != null)
            {
                countdownScript.StartCoroutine(countdownScript.Countdown());
            }
        }

        if (collision.gameObject.CompareTag("Portal"))
        {
            Vector3 randomoposition = new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY), -0.1f);

            transform.position = randomoposition;
        }


        // Reset Playerhastouched after each collision

    }
}
 