using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minus_count : MonoBehaviour
{
    public Text ScriptTxt;

    int minus = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScriptTxt.text = "0";
    }

    // Update is called once per frame
    public void CountMinus()
    {
        minus += 1;
        ScriptTxt.text = minus.ToString();
    }
}
