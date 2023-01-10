using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Out : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf == true)
        {
            panel.SetActive(false);
            panel2.SetActive(false);
        }
    }
}
