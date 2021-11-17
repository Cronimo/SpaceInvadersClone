using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    Rigidbody2D rb;

    SpriteRenderer sprt;

    public GameObject child;

    public SpriteRenderer bullet;

    float speed = 12;

    private void Start()
    {
        sprt = child.GetComponent<SpriteRenderer>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        BulletShot();
        if(transform.position.y > 6)
        {
            TankMovement.bulletCount = 0;
            Destroy(this.gameObject);
        }
    }

    void BulletShot()
    {
        rb.velocity = new Vector2(rb.velocity.x, speed);        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            TankMovement.bulletCount = 0;
            Destroy(this.gameObject);
            
        }
        if(other.gameObject.tag.Equals("Corner"))
        {
            TankMovement.bulletCount = 0;
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag.Equals("Block"))
        {
            TankMovement.bulletCount = 0;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag.Equals("UpperBlock"))
        {
            TankMovement.bulletCount = 0;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag.Equals("Leg"))
        {
            TankMovement.bulletCount = 0;
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag.Equals("UpBnd"))
        {
            TankMovement.bulletCount = 0;
            Destroy(this.gameObject, .5f);
            speed = 0f;
            sprt.enabled = !sprt.enabled;
            bullet.enabled = !bullet.enabled;
        }

    }
}
