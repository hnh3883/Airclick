using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalprice : MonoBehaviour
{
    public Transform check1, check2, check3, check4;
    public Text price1, price2, price3, price4, total_price;
    private int p1, p2, p3, p4, p5;
    // Start is called before the first frame update
    void Start()
    {
        total_price.gameObject.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        if (check1.gameObject.activeSelf == true)
        {
            p1 = int.Parse(price1.text);
        }
        else
        {
            p1 = 0;
        }

        if (check2.gameObject.activeSelf == true)
        {
            p2 = int.Parse(price2.text);
        }
        else
        {
            p2 = 0;
        }

        if (check3.gameObject.activeSelf == true)
        {
            p3 = int.Parse(price3.text);
        }
        else
        {
            p3 = 0;
        }

        if (check4.gameObject.activeSelf == true)
        {
            p4 = int.Parse(price2.text);
        }
        else
        {
            p4 = 0;
        }

        p5 = p1 + p2 + p3 + p4;

        if (check1.gameObject.activeSelf == true)
        {
                total_price.gameObject.SetActive(true);
                total_price.text = "총 결제금액 " + p5 + '원'; ;

        }
        else
        {
            total_price.gameObject.SetActive(false);

        }
        

    }
}
