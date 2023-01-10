using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plus_count : price
{
    public Text ScriptTxt;
    public Text total;

    public int plus = 1;
    public int minus = 1;

    // Start is called before the first frame update
    public void Start()
    {
        ScriptTxt.text = "1";
    }

    // Update is called once per frame
    public void CountPlus()
    {
        if (plus <= minus) { plus = 1; minus = 1; }
        plus += 1;
        //   int aaa = plus;
        PlayerPrefs.SetInt("plus", plus);
        print("+" + plus);
    }


    public void CountMinus()
    {
        int aa = PlayerPrefs.GetInt("plus");
        print("+" + aa);
        if (aa > 1)
        {
            minus -= 1;
            if (aa + minus < 1)
                minus += 1;
        }
        int bbb = minus;
        PlayerPrefs.SetInt("minus", bbb);
        print("-" + bbb);

    }

    public void ssumm()
    {
        int aa = PlayerPrefs.GetInt("plus");
        int bb = PlayerPrefs.GetInt("minus");
        int cc = aa + bb;
        if (cc < 1)
        {
            aa = 1; bb = 0;
            PlayerPrefs.SetInt("plus", aa);
            PlayerPrefs.SetInt("minus", bb);
            cc = aa + bb;

        }
        ScriptTxt.text = cc.ToString();

        int ss= PlayerPrefs.GetInt("sangsock");
        int sscc = ss * cc;
        Debug.Log(sscc);

        total.text = sscc.ToString();


    }


}


