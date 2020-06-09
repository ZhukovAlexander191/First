using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour
{
    public int health = 10;
    public int numLives;

    public Image[] lives;

    public Sprite FullLive;
    public Sprite EmptyLive;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            lives[0].sprite = EmptyLive;
            Destroy(gameObject);
            panel.SetActive(true);
        }      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("DEATH"))
        {
            health = 0;
        }
    }

}

