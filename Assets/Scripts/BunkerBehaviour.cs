using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunkerBehaviour : MonoBehaviour
{
    SpriteRenderer sprt;

    public GameObject child1;
    public GameObject child2;
    private float health = 3;

    private void Start()
    {
        sprt = gameObject.GetComponent<SpriteRenderer>();
        child1 = this.gameObject.transform.GetChild(0).gameObject;
        child2 = this.gameObject.transform.GetChild(1).gameObject;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Demolish();
        
    }

    void Demolish()
    {
        switch (health)
        {
        case 3:
            health--;
            sprt.enabled = !sprt.enabled;
            child1.SetActive(true);
        break;
        case 2:
             health--;
             child1.SetActive(false);
             child2.SetActive(true);
        break;
        case 1:
             Destroy(this.gameObject);
        break;
        default:
            break;
        }
    }
}
