using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KiilPlayer : MonoBehaviour
{
    LifesImproved player;
    private void Start()
    {

        player = GameObject.Find("Hero").GetComponent<LifesImproved>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Hero"))
        {
            player.Death();
        }
    }
}
