using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRAPLOLKill : MonoBehaviour
{
    PlayerControl player;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            rb.isKinematic = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            player.TakeDamage(10);
        }

        if (collision.gameObject.name.Equals("DEADFlor"))
        {
            Destroy(gameObject);
        }

    }
}
