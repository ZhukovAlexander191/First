using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esc : MonoBehaviour
{
    public KeyCode MyKey;
    Button JustKlickIt;
    void Start()
    {
        JustKlickIt = GetComponent<Button>();
    }
    void Update()
    {
        if (Input.GetKeyDown(MyKey))
        {
            JustKlickIt.onClick.Invoke();
        }
    }
}
