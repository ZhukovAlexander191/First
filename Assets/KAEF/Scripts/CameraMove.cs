using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, -2.42f, -10f);   
    }
}
