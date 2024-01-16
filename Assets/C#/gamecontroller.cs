using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
        }

    }

    void Die()
    {
        StartCoroutine(Respawn(0.0f));

    }

    IEnumerator Respawn(float duartion)
    {
        yield return new WaitForSeconds(duartion);
        transform.position = startPos;
    }



}
