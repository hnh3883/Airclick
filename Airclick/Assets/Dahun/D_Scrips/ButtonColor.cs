using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonColor : MonoBehaviour
{
    public GameObject panel;
    public Button btn1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf == true)
        {
            btn1.onClick.Invoke();
        }
    }
}
