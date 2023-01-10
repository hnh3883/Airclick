using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class First_Button : MonoBehaviour
{
    public Button yourButton;
    public GameObject First_panel;
    public GameObject Main_Panel;
    public Button checkButton;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        First_panel.SetActive(false);
        Main_Panel.SetActive(true);
        checkButton.onClick.Invoke();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
