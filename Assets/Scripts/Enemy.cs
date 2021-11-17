using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
     Rigidbody2D rb;

     SpriteRenderer sprt;

     BoxCollider2D bxC;

     AudioSource audioSrc;

     GameObject child;

     SpriteRenderer childSprt;


    float direction = .5f;
    float x = 0f, y = 0f;
    float time = 0;

    bool canShoot;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sprt = gameObject.GetComponent<SpriteRenderer>();
        bxC = gameObject.GetComponent<BoxCollider2D>();
        audioSrc = gameObject.GetComponent<AudioSource>();
        child = this.gameObject.transform.GetChild(0).gameObject;
        childSprt = child.GetComponent<SpriteRenderer>();
    }

    private void Update(){

       switch(Mathf.Round(time)){

        case 4: 
            y = -1f;
            x = 0;
            break;
        case 5: 
            y = 0;
            x = 1f;
            break;
        case 13: 
            y = -1f;
            x = 0;    
            break;
        case 14: 
            y = 0;
            x = -1f;    
            break;
        default: 
            break;
       }
        
        rb.velocity = new Vector2(x*direction,y*direction);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        sprt.enabled = !sprt.enabled;
        bxC.enabled = !bxC.enabled;
        audioSrc.Play();
        childSprt.enabled = !childSprt.enabled;

        if (other.gameObject.tag == "Bullet") {
        Destroy(this.gameObject,.5f);
        }
    }

    

}
