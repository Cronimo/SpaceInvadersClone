using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject bullet;

    private bool introPlaying;

    private float speed = 11;
    private float isMoving;
    public static float bulletCount;


    public void IntroPlaying()
    {
        introPlaying = !introPlaying;
    }

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        bullet.transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.y);
        if (introPlaying == false)
        {
            isMoving = Input.GetAxisRaw("Horizontal");
        }
        if (Input.GetKeyDown("space") && bulletCount==0 && introPlaying == false)
        {
            Instantiate(bullet);
            bulletCount++;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(isMoving * speed, rb.velocity.y);
    }
}
