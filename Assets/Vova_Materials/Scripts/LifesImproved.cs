using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifesImproved : MonoBehaviour
{
    public int health = 10;
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
            Destroy(gameObject);
            panel.SetActive(true);
        }
    }
   public void Death()
        {
            health = 0;
        }

}
