using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class check_panel3 : MonoBehaviour
{
    public GameObject coffee_panel;
    public GameObject tea_panel;
    public GameObject ade_panel;
    public Text me;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (coffee_panel.activeSelf == false && tea_panel.activeSelf == false && ade_panel.activeSelf == false)
        {
            me.text = "0";
        }
    }
}
