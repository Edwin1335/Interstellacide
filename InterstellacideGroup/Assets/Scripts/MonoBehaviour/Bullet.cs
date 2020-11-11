using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;

    public Sprite upgradedBullet;
    public int cuPoints;
    private const int pointsGoal = 3;

    void Start()
    {
        //rigid body move right according to speed
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        Destroy(this.gameObject, 4);

        if (cuPoints >= pointsGoal)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = upgradedBullet;
        }
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
