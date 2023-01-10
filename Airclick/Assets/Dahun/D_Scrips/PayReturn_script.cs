using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PayReturn_script : MonoBehaviour
{
    public GameObject panel;
    public Button yourButton;
    public Button checkButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
       
        panel.SetActive(true);
        checkButton.onClick.Invoke();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
