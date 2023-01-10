using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one : MonoBehaviour
{
    public GameObject coffee_scroll;
    public GameObject tea_scroll;
    public GameObject ade_scroll;
    public GameObject desert_scroll;
    public GameObject tea_order;
    public GameObject coffee_order;
    public GameObject ade_order;

    public GameObject b1,b2,g1,g2,b3;


    public GameObject c1, c2, c3, c4, c5, c6;
    public GameObject t1, t2, t3, t4, t5, t6;
    public GameObject d1, d2, d3, d4, d5, d6;
    // Start is called before the first frame update
    void Start()
    {

        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        c5.SetActive(false);
        c6.SetActive(false);
        t1.SetActive(false);
        t2.SetActive(false);
        t3.SetActive(false);
        t4.SetActive(false);
        t5.SetActive(false);
        t6.SetActive(false);
        d1.SetActive(false);
        d2.SetActive(false);
        d3.SetActive(false);
        d4.SetActive(false);
        d5.SetActive(false);
        d6.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (coffee_scroll.activeSelf == true)
        {
            b3.SetActive(false);

            if (c1.activeSelf == false)
            {
                b1.SetActive(true);
                g1.SetActive(true);
                b2.SetActive(false);
                g2.SetActive(false);
            }
            else { 
                b1.SetActive(false);
                g1.SetActive(false);
                b2.SetActive(true);
                g2.SetActive(true);
            }
        }
       
        else if (tea_scroll.activeSelf == true)
        {
            b3.SetActive(false);

            if (t1.activeSelf == false)
            {
                b1.SetActive(true);
                g1.SetActive(true);
                b2.SetActive(false);
                g2.SetActive(false);
            }
            if (t1.activeSelf == true)
            {
                b1.SetActive(false);
                g1.SetActive(false);
                b2.SetActive(true);
                g2.SetActive(true);
            }
        }
        else if (desert_scroll.activeSelf == true)
        {
            b3.SetActive(false);

            if (d1.activeSelf == false)
            {
                b1.SetActive(true);
                g1.SetActive(true);
                b2.SetActive(false);
                g2.SetActive(false);
            }
            if (d1.activeSelf == true)
            {
                b1.SetActive(false);
                g1.SetActive(false);
                b2.SetActive(true);
                g2.SetActive(true);
            }
        }
        else if (ade_scroll.activeSelf == true)
        {
            b3.SetActive(true);
        }
        if (coffee_order.activeSelf == true|| tea_order.activeSelf == true||ade_scroll.activeSelf == true)
        {
            b2.SetActive(false);
            g2.SetActive(false);

            b1.SetActive(false);
            g1.SetActive(false);


        }
        else if(ade_order.activeSelf == true)
        {
            b3.SetActive(false);

        }



    }
}
