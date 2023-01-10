using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TeaMenuScript : MonoBehaviour
{


    public GameObject Tea; //Cmm, Ppm, Glt, Pit, Flt; //티종류

    public Button TeaBtn; //CmmBtn, PpmBtn, GltBtn, PitBtn, Fltbtn;

    public string TeaStr;

    public GameObject TeaPanel, BigPanel;


    void Start()
    {
        //Egy = GameObject.Find("얼");
        TeaBtn = this.transform.GetComponent<Button>();

        TeaBtn.onClick.AddListener(OpenPanel);
        TeaBtn.onClick.AddListener(TeaClick);
    }
    public void TeaClick()
    {
        TeaStr = this.name.ToString();
        //Debug.Log("클릭 원소98 :: " + TeaStr);
        PlayerPrefs.SetString("TeaDeliver", TeaStr);
    }




    public void OpenPanel()
    {
         TeaPanel.SetActive(true);
        BigPanel.SetActive(true);


    }

}
