using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MainMenuScript : MonoBehaviour
{
    public GameObject Ame, Cfl, Bnl, Dry, Cnm, Hzn; //커피종류

    public Button AmeBtn, CflBtn, btnn, BnlBtn, DryBtn, CnmBtn, HznBtn;
    public string AmeStr;
    public GameObject Panel1, Panel2;



    // Start is called before the first frame update
    void Start()
    {
        btnn = this.transform.GetComponent<Button>();

        Ame = GameObject.Find("아메리카노");
        AmeBtn = Ame.transform.GetComponent<Button>();

        Cfl = GameObject.Find("카페라떼");
        CflBtn = Cfl.transform.GetComponent<Button>();

        Dry = GameObject.Find("드라이 카푸치노");
        DryBtn = Dry.transform.GetComponent<Button>();

        Cnm = GameObject.Find("시나몬 라떼");
        CnmBtn = Cnm.transform.GetComponent<Button>();

        Hzn = GameObject.Find("헤이즐넛 라떼");
        HznBtn = Hzn.transform.GetComponent<Button>();

        Bnl = GameObject.Find("바닐라 라떼");
        BnlBtn = Bnl.transform.GetComponent<Button>();

       // Egy = GameObject.Find("얼");
       // EgyBtn = Egy.transform.GetComponent<Button>();
        //CmmBtn = Cmm.transform.GetComponent<Button>();
        //PpmBtn = Ppm.transform.GetComponent<Button>();
        //GltBtn = Glt.transform.GetComponent<Button>();
        //PitBtn = Pit.transform.GetComponent<Button>();
        //Fltbtn = Flt.transform.GetComponent<Button>();

        if (btnn != null)
        {
            btnn.onClick.AddListener(OpenPanel);
            AmeBtn.onClick.AddListener(AmeClick);
            CflBtn.onClick.AddListener(CflClick);
            BnlBtn.onClick.AddListener(BnlClick);
            DryBtn.onClick.AddListener(DryClick);
            CnmBtn.onClick.AddListener(CnmClick);
            HznBtn.onClick.AddListener(HznClick);

            //EgyBtn.onClick.AddListener(TeaClick);
            //CmmBtn.onClick.AddListener(Cmm2);
            //PpmBtn.onClick.AddListener(Ppm3);
            //GltBtn.onClick.AddListener(Glt4);
            //PitBtn.onClick.AddListener(Pit5);
            //Fltbtn.onClick.AddListener(Flt6);
        }

    }
    //public void TeaClick()
    //{

    //    AmeStr = Egy.name.ToString();
    //    Debug.Log("클릭 원소1 :: " + AmeStr);
    //    PlayerPrefs.SetString("AmeSex", AmeStr);
    //}

    //Egy, Cmm, Ppm, Glt, Pit, Flt;
    //public void Flt1()
    //{
    //    TeaClick(Flt);
    //}
    //public void Cmm2()
    //{
    //    TeaClick(Cmm);
    //}
    //public void Ppm3()
    //{
    //    TeaClick(Ppm);
    //}
    //public void Glt4()
    //{
    //    TeaClick(Glt);
    //}
    //public void Pit5()
    //{
    //    TeaClick(Pit);
    //}
    //public void Flt6()
    //{
    //    TeaClick(Flt);
    //}

    public void CflClick()
    {

        AmeStr = Cfl.name.ToString();
        Debug.Log("클릭 원소1 :: " + AmeStr);
        PlayerPrefs.SetString("AmeSex", AmeStr);
    }

    public void AmeClick()
    {

        AmeStr = Ame.name.ToString();
        Debug.Log("클릭 원소1 :: " + AmeStr);
        PlayerPrefs.SetString("AmeSex", AmeStr);

    }

    public void BnlClick()
    {
        AmeStr = Bnl.name.ToString();

        PlayerPrefs.SetString("AmeSex", AmeStr);

    }

    public void DryClick()
    {
        AmeStr = Dry.name.ToString();

        PlayerPrefs.SetString("AmeSex", AmeStr);

    }

    public void CnmClick()
    {
        AmeStr = Cnm.name.ToString();

        PlayerPrefs.SetString("AmeSex", AmeStr);

    }

    public void HznClick()
    {
        AmeStr = Hzn.name.ToString();

        PlayerPrefs.SetString("AmeSex", AmeStr);

    }


    public void OpenPanel()
    {
        if (Panel1 != null)
        {

            Panel1.SetActive(true);
            Panel2.SetActive(true);

        }
    }
}
