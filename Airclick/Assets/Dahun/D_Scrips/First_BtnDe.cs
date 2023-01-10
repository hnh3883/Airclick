using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class First_BtnDe : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    private int i;
    void Start()
    {
       


    }
    void Update()
    {
        btn1.onClick.Invoke();
        btn2.onClick.Invoke();
        btn3.onClick.Invoke();
        btn4.onClick.Invoke();
    }
}
