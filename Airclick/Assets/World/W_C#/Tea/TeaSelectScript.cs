using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TeaSelectScript : TeaMenuScript
{
    public Button TeaAddBtn;

    // Start is called before the first frame update
    void Start()
    {
        TeaAddBtn = this.transform.GetComponent<Button>(); //추가하기 버튼을 누름

        TeaAddBtn.onClick.AddListener(order);
        TeaAddBtn.onClick.AddListener(ClosedTeaPanel);
    }

    // Update is called once per frame
    public void order()
    {
        string TeaStrED = PlayerPrefs.GetString("TeaDeliver");
        Debug.Log("클릭 원소 :: " + TeaStrED);
    }

    public void ClosedTeaPanel()
    {
        TeaPanel.SetActive(false);
    }
}
