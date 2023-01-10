using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class newBoxCount : MonoBehaviour
{
    public GameObject stack1, stack2, stack3, stack4;
    public Text[] CountTxt;
    int[] integer = new int[4];
    public Button adBtn, adBtn2, adBtn3, Xbtn1, Xbtn2, Xbtn3, Xbtn4;
    public Button desertBtn1, desertBtn2, desertBtn3, desertBtn4, desertBtn5, desertBtn6;
    public Button desertBtn11, desertBtn22, desertBtn33, desertBtn44, desertBtn55, desertBtn66;
    public Text price1, price2, price3, price4;


    public string DesStr;

   

    // Start is called before the first frame update
    void Start()
    {
        integer[0] = 0;
        integer[1] = 0;
        integer[2] = 0;
        integer[3] = 0;

        desertBtn1.onClick.AddListener(DesClick1);
        desertBtn2.onClick.AddListener(DesClick2);
        desertBtn3.onClick.AddListener(DesClick3);
        desertBtn4.onClick.AddListener(DesClick4);
        desertBtn5.onClick.AddListener(DesClick5);
        desertBtn6.onClick.AddListener(DesClick6);
        desertBtn11.onClick.AddListener(DesClick11);
        desertBtn22.onClick.AddListener(DesClick22);
        desertBtn33.onClick.AddListener(DesClick33);
        desertBtn44.onClick.AddListener(DesClick44);
        desertBtn55.onClick.AddListener(DesClick55);
        desertBtn66.onClick.AddListener(DesClick66);

        desertBtn1.onClick.AddListener(BoxCount2);
        desertBtn2.onClick.AddListener(BoxCount2);
        desertBtn3.onClick.AddListener(BoxCount2);
        desertBtn4.onClick.AddListener(BoxCount2);
        desertBtn5.onClick.AddListener(BoxCount2);
        desertBtn6.onClick.AddListener(BoxCount2);
        desertBtn11.onClick.AddListener(BoxCount2);
        desertBtn22.onClick.AddListener(BoxCount2);
        desertBtn33.onClick.AddListener(BoxCount2);
        desertBtn44.onClick.AddListener(BoxCount2);
        desertBtn55.onClick.AddListener(BoxCount2);
        desertBtn66.onClick.AddListener(BoxCount2);

        adBtn.onClick.AddListener(BoxCount);
        adBtn2.onClick.AddListener(BoxCount);
        adBtn3.onClick.AddListener(BoxCount);
        

        Xbtn1.onClick.AddListener(Xdelete1);
        Xbtn2.onClick.AddListener(Xdelete2);
        Xbtn3.onClick.AddListener(Xdelete3);
        Xbtn4.onClick.AddListener(Xdelete4);

        

    }
    public void DesClick11()
    {
        DesStr = desertBtn11.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }
    public void DesClick22()
    {
        DesStr = desertBtn22.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }
    public void DesClick33()
    {
        DesStr = desertBtn33.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }
    public void DesClick44()
    {
        DesStr = desertBtn44.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }
    public void DesClick55()
    {
        DesStr = desertBtn55.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }
    public void DesClick66()
    {
        DesStr = desertBtn66.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }



    public void DesClick1()
    {
        DesStr = desertBtn1.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }

    public void DesClick2()
    {
        DesStr = desertBtn2.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }

    public void DesClick3()
    {
        DesStr = desertBtn3.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }

    public void DesClick4()
    {
        DesStr = desertBtn4.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }

    public void DesClick5()
    {
        DesStr = desertBtn5.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }

    public void DesClick6()
    {
        DesStr = desertBtn6.name.ToString();
        //Debug.Log("클릭 원소k :: " + DesStr);
        PlayerPrefs.SetString("DesertDeliver", DesStr);
    }

    public void BoxCount2()
    {
        int SetText4 = 0;
        string SetText3 = PlayerPrefs.GetString("DesertDeliver");
        //Debug.Log("이게뭐야 ::" + SetText3);

        stack1.SetActive(true);
        if (SetText3.Contains("쿠키"))
        {
            SetText4 = 1200;
        }
        if (SetText3.Contains("베이글칩"))
        {
            SetText4 = 2000;
        }
        if (SetText3.Contains("마카롱"))
        {
            SetText4 = 1500;
        }
        if (integer[0] == 0 && stack1 != null)
        {
            CountTxt[0].text = SetText3+'\n'+'\n' + "<     1     >     "+SetText4 +'원';
            //Debug.Log("디저트 클릭원소 : " + SetText3);
            price1.text = SetText4.ToString();

            //Debug.Log("스택 원소 :: " + st);
            integer[0] = 1;
        }


        else if (integer[0] == 1 && integer[1] == 0 && stack2 != null)
        {
            stack2.SetActive(true);
            price2.text = SetText4.ToString();

            CountTxt[1].text = SetText3 + '\n' + '\n' + "<     1     >     "+SetText4 + '원'; ;
            //Debug.Log("하염2");
            integer[1] = 1;

        }
        else if (integer[0] == 1 && integer[1] == 1 && integer[2] == 0 && stack3 != null)
        {
            stack3.SetActive(true);
            price3.text = SetText4.ToString();

            CountTxt[2].text = SetText3 + '\n' + '\n' + "<     1     >     "+SetText4 + '원'; ;
            //Debug.Log("하염3");
            integer[2] = 1;
        }

        else if (integer[0] == 1 && integer[1] == 1 && integer[2] == 1 && integer[3] == 0 && stack4 != null)
        {
            price4.text = SetText4.ToString();

            stack4.SetActive(true);
            CountTxt[3].text = SetText3 + '\n' + '\n' + "<     1     >     "+SetText4 + '원'; ;
            //Debug.Log("하염3");
            integer[3] = 1;
        }
    }

    // Update is called once per frame
    public void BoxCount()
    {
        int SetText3 = 0;
        string SetText2 = PlayerPrefs.GetString("textSet");
        string SetText = PlayerPrefs.GetString("TeaDeliver");
        
        if (SetText.Contains("베이글칩")||SetText == "아메리카노")
        {
            SetText3 = 2000;
        }
        if (SetText == "카페라떼" || SetText == "헤이즐넛 라떼"|| SetText == "얼그레이" || SetText == "캐모마일"|| SetText == "페퍼민트")
        {
            SetText3 = 2500;
        }
        if (SetText == "바닐라 라떼" || SetText == "시나몬 라떼" || SetText == "드라이 카푸치노"|| SetText == "진저 레몬티" || SetText == "복숭아 아이스티" || SetText == "생과일 레몬티")
        {
            SetText3 = 3000;
        }
        if (SetText == "피치 블로썸"|| SetText == "자두티")
        {
            SetText3 = 3300;
        }
        if (SetText == "돌체라떼" || SetText == "아인슈페너"|| SetText == "생과일 자몽티" || SetText == "밀크티")
        {
            SetText3 = 3500;
        }
        if (SetText.Contains("에이드") || SetText == "카라멜 마끼야또" || SetText == "초코 카페모카" || SetText == "달고나 라떼" || SetText == "뱅쇼")
        {
            SetText3 = 3800;
        }
        if (SetText == "코코슈페너" || SetText == "모렝 아이스티")
        {
            SetText3 = 4000;
        }
        if (SetText2.Contains("GRANDE"))
        {
            SetText3 += 500;
        }
        else if (SetText2.Contains("VENTI"))
        {
            SetText3 += 1000;
        }
        if (SetText2.Contains("1SHOT"))
        {
            SetText3 += 500;
        }
        else if (SetText2.Contains("2SHOT"))
        {
            SetText3 += 1000;
        }
        //Debug.Log("박카 텍스트는 ::" + SetText);
        //배열말고 스택쓰기

        stack1.SetActive(true);


        if (integer[0] == 0 && stack1 != null)
        {
            CountTxt[0].text = SetText + '\n' + SetText2 + '\n' + "<     1     >     " + SetText3+"원";
            //Debug.Log("하염1");
            price1.text = SetText3.ToString();
            //Debug.Log("스택 원소 :: " + st);
            integer[0] = 1;
            
        }


        else if (integer[0] == 1 && integer[1] == 0 && stack2 != null)
        {
            stack2.SetActive(true);
            price2.text = SetText3.ToString();

            CountTxt[1].text = SetText + '\n' + SetText2+ '\n' + "<     1     >     " + SetText3+"원";
            //Debug.Log("하염2");
            integer[1] = 1;

        }
        else if (integer[0] == 1 && integer[1] == 1 && integer[2] == 0 && stack3 != null)
        {
            stack3.SetActive(true);
            price3.text = SetText3.ToString();

            CountTxt[2].text = SetText + '\n' + SetText2 + '\n' + "<     1     >     " + SetText3 + "원";
            //Debug.Log("하염3");
            integer[2] = 1;
        }

        else if (integer[0] == 1 && integer[1] == 1 && integer[2] == 1 && integer[3] == 0 && stack4 != null)
        {
            stack4.SetActive(true);
            price4.text = SetText3.ToString();

            CountTxt[3].text = SetText + '\n' + SetText2 + '\n' + "<     1     >     " + SetText3 + "원";
            //Debug.Log("하염3");
            integer[3] = 1;
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

    public void Xdelete4()
    {
        stack4.SetActive(false);
        integer[3] = 0;
    }
}
