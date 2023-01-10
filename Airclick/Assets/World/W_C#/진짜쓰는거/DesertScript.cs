using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DesertScript : MonoBehaviour
{


   // public GameObject Tea; //Cmm, Ppm, Glt, Pit, Flt; //티종류

    public Button DesBtn; //CmmBtn, PpmBtn, GltBtn, PitBtn, Fltbtn;

    public string DesStr;



    void Start()
    {
        //Egy = GameObject.Find("얼");
        DesBtn = this.transform.GetComponent<Button>();

        DesBtn.onClick.AddListener(DesClick);
    }
    public void DesClick()
    {
        DesStr = this.name.ToString();
        Debug.Log("클릭 원소De :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }


}
