using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class countScript : MainMenuScript
{

    public Text[] CountTxt;

    int[] integer = new int[3];

    // Start is called before the first frame update
    public GameObject Ice, Hot, Basic, OneS, TwoS, Tall, Grande, Venti, addd, stack1, stack2, stack3;
    public Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, Xbtn1, Xbtn2, Xbtn3;
    public GameObject Panel;
    public string world, world2, world3;
    public TextBoxScript manager;
    bool judge;
    public Button dahun_btn1, dahun_btn2, dahun_btn3;
    public GameObject dahun_panel;
    private int dahun_i;
    // Start is called before the first frame update

    void Start()
    {
        integer[0] = 0;
        integer[1] = 0;
        integer[2] = 0;
        dahun_i = 0;
        addd = GameObject.Find("추가하기");

        Ice = GameObject.Find("ICE");
        Hot = GameObject.Find("HOT");

        Basic = GameObject.Find("BASIC");
        OneS = GameObject.Find("1SHOT");
        TwoS = GameObject.Find("2SHOT");
        Tall = GameObject.Find("TALL");

        Grande = GameObject.Find("GRANDE");
        Venti = GameObject.Find("VENTI");

        btn1 = addd.transform.GetComponent<Button>();

        btn2 = Ice.transform.GetComponent<Button>();
        btn3 = Hot.transform.GetComponent<Button>();

        btn4 = Basic.transform.GetComponent<Button>();
        btn5 = OneS.transform.GetComponent<Button>();
        btn6 = TwoS.transform.GetComponent<Button>();

        btn7 = Tall.transform.GetComponent<Button>();
        btn8 = Grande.transform.GetComponent<Button>();
        btn9 = Venti.transform.GetComponent<Button>();

        Ame = GameObject.Find("아메리카노");
        AmeBtn = Ame.transform.GetComponent<Button>();

        Cfl = GameObject.Find("카페라떼");
        CflBtn = Cfl.transform.GetComponent<Button>();
        

        //stack1 = GameObject.Find("TextBox1");
        //stack2 = GameObject.Find("TextBox2");
        //stack3 = GameObject.Find("TextBox3");

        // Bnl = GameObject.Find("바닐라 라떼");
        //  BnlBtn = Bnl.transform.GetComponent<Button>();

        // if (btn1 != null)
        // {
            AmeBtn.onClick.AddListener(AmeClick);
            CflBtn.onClick.AddListener(CflClick);
        //BnlBtn.onClick.AddListener(Awake);

            btn2.onClick.AddListener(CountIce);
            btn3.onClick.AddListener(CountHot);

            btn4.onClick.AddListener(CountBASIC);
            btn5.onClick.AddListener(CountOneShot);
            btn6.onClick.AddListener(CountTwoShot);

            btn7.onClick.AddListener(CountTALL);
            btn8.onClick.AddListener(CountGRANDE);
            btn9.onClick.AddListener(CountVENTI);

            //btn1.onClick.AddListener(OpenPanel);  
            btn1.onClick.AddListener(AtomClick);         //스크립트로 버튼 이벤트 수행
            btn1.onClick.AddListener(ClosedPanel);

            Xbtn1.onClick.AddListener(Xdelete1);
            Xbtn2.onClick.AddListener(Xdelete2);
            Xbtn3.onClick.AddListener(Xdelete3);
        //   }
    }
    void Update()
    {
        if (dahun_panel.activeSelf == true && dahun_i == 0)
        {
            dahun_btn1.onClick.Invoke();
            dahun_btn2.onClick.Invoke();
            dahun_btn3.onClick.Invoke();
            dahun_i = 1;
        }
        if (dahun_panel.activeSelf == false)
        {
            dahun_i = 0;
        }
    }
    public void Xdelete1()
    {
        stack1.SetActive(false);
        integer[0] = 0;
    }
    public void Xdelete2()
    {
        stack2.SetActive(false);
        integer[1] = 0;
    }
    public void Xdelete3()
    {
        stack3.SetActive(false);
        integer[2] = 0;
    }

    public void AtomClick()
    {


        string aa = PlayerPrefs.GetString("AmeSex");
        Debug.Log("클릭 원소 :: " + aa + world + world2 + world3);
        string textfull = $"{aa + '\n' + world + " / " + world2 + " / " + world3}";
        //배열말고 스택쓰기

        stack1.SetActive(true);


        if (integer[0] == 0 && stack1 != null)
        {
            CountTxt[0].text = textfull;
            Debug.Log("하염1");

            //Debug.Log("스택 원소 :: " + st);
            integer[0] = 1;
        }


        else if (integer[0] == 1 && integer[1] == 0 && stack2 != null)
        {
           stack2.SetActive(true);

           CountTxt[1].text = textfull;
            Debug.Log("하염2");
            integer[1] = 1;

        }
        else if (integer[0] == 1 && integer[1] == 1 && integer[2] == 0 && stack3 != null)
        {
            stack3.SetActive(true);
            CountTxt[2].text = textfull;
            Debug.Log("하염3");
            integer[2] = 1;
        }


    }

        public void ClosedPanel()
    {
        

        if (Panel != null)
        {
            
           // btn4.OnClick.Select();
           // btn7.OnClick.Select();


            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
           // Panel3.SetActive(!isActive);
        }
    }

    public void CountIf(GameObject gameObject)
    {
        world = gameObject.name.ToString();
    }

    public void CountIce()
        {
        //world = Ice.name.ToString();
        CountIf(Ice);
        }

    public void CountHot()
        {
            world = Hot.name.ToString();
        }

    public void CountBASIC()
        {
            world2 = Basic.name.ToString();
        }

    public void CountOneShot()
        {
            world2 = OneS.name.ToString();
        }

    public void CountTwoShot()
        {
            world2 = TwoS.name.ToString();
        }

    public void CountTALL()
        {
            world3 = Tall.name.ToString();
        }

    public void CountGRANDE()
        {
            world3 = Grande.name.ToString();
        }

    public void CountVENTI()
        {
            world3 = Venti.name.ToString();
        }


}