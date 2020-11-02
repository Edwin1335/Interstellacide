using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;

    void Start()
    {
        //rigid body move right according to speed
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        Destroy(this.gameObject, 4);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if collision object has  tag "Enemy", aka coins, hearts, etc...
        if (collision.gameObject.CompareTag("Enemy"))
        {
            print("HIT ENEMY");
            Destroy(gameObject, .01f);
        }
    }
}
