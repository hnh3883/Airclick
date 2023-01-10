using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class CancelScript : MonoBehaviour
{
    public GameObject Cancel;
    public Button CancelBtn;
    // Start is called before the first frame update
    void Start()
    {
        CancelBtn = this.transform.GetComponent<Button>();
        CancelBtn.onClick.AddListener(ClosecPanel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosecPanel()
    {
        Cancel.SetActive(false);


    }
}
