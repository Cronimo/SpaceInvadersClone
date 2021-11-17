using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBulletBehaviour : MonoBehaviour
{
    private float speed = -7;

    Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
        Destroy(this.gameObject);
    }
}
