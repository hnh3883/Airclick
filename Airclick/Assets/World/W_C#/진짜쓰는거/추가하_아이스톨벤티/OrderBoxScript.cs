using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OrderBoxScript : MonoBehaviour
{
    public GameObject TeaPanel;
    public Button adBtn, IceBtn, HotBtn,  VentiBtn, GrandeBtn, TallBtn, BasicBtn, OneSBtn, TwoSBtn;
    public string IceHot, Size, Shot, textfull;
    public GameObject panel;
    public Text testText;
    // Start is called before the first frame update
    void Start()
    {
        adBtn = this.transform.GetComponent<Button>();


        //adBtn.onClick.AddListener(BoxCount);


        IceBtn.onClick.AddListener(CountIce);
        HotBtn.onClick.AddListener(CountHot);

        TallBtn.onClick.AddListener(CountTall);
        GrandeBtn.onClick.AddListener(CountGrande);
        VentiBtn.onClick.AddListener(CountVenti);

        BasicBtn.onClick.AddListener(CountBASIC);
        OneSBtn.onClick.AddListener(CountOneShot);
        TwoSBtn.onClick.AddListener(CountTwoShot);

        //adBtn.onClick.AddListener(text1);
        adBtn.onClick.AddListener(ClosedTeaPanel);
    }
    void Update()
    {
        if (panel.gameObject.name == "CoffeeMenu" && panel.activeSelf == true && testText.text == "0")
        {
            IceBtn.onClick.Invoke();
            TallBtn.onClick.Invoke();
            BasicBtn.onClick.Invoke();
            testText.text = "1";
        }
        if (panel.gameObject.name == "TeaMenu" && panel.activeSelf == true && testText.text == "0")
        {
            IceBtn.onClick.Invoke();
            TallBtn.onClick.Invoke();
            testText.text = "1";
        }
        if (panel.gameObject.name == "AdeMenu" && panel.activeSelf == true &&testText.text == "0")
        {
            TallBtn.onClick.Invoke();
            testText.text = "1";
        }
       
        
       
    }

    // Update is called once per frame
    public void text1()
    {
        //string aa = PlayerPrefs.GetString("TeaDeliver");
        textfull = $"{IceHot + " " + Shot + " " + Size}";

        //Debug.Log("텍스트는 ::" + textfull);
    }

    public void ClosedTeaPanel()
    {
        TeaPanel.SetActive(false);

    }

    public void CountIce()
    {
        //world = Ice.name.ToString();
        IceHot = "ICE / ";
        textfull = IceHot + Shot + Size;
        //Debug.Log("아이스는 :: " + textfull);
        PlayerPrefs.SetString("textSet", textfull);
    }

    public void CountHot()
    {
        //world = Ice.name.ToString();
        IceHot = "HOT / ";
        textfull = IceHot + Shot + Size;
        PlayerPrefs.SetString("textSet", textfull);
    }

    public void CountTall()
    {
        //world = Ice.name.ToString();
        Size = "TALL";
        textfull = IceHot + Shot + Size;
        //Debug.Log("톨은 :: " + textfull);
        PlayerPrefs.SetString("textSet", textfull);

    }

    public void CountGrande()
    {
        //world = Ice.name.ToString();
        Size = "GRANDE";
        textfull = IceHot + Shot + Size;
        PlayerPrefs.SetString("textSet", textfull);
    }

    public void CountVenti()
    {
        //world = Ice.name.ToString();
        Size = "VENTI";
        textfull = IceHot + Shot + Size;
        PlayerPrefs.SetString("textSet", textfull);
    }

    public void CountBASIC()
    {
        Shot = "BASIC / ";
        textfull = IceHot + Shot + Size;
        PlayerPrefs.SetString("textSet", textfull);
    }

    public void CountOneShot()
    {
        Shot = "+1SHOT / ";
        textfull = IceHot + Shot + Size;
        PlayerPrefs.SetString("textSet", textfull);
    }

    public void CountTwoShot()
    {
        Shot = "+2SHOT / ";
        textfull = IceHot + Shot + Size;
        PlayerPrefs.SetString("textSet", textfull);
    }




}
