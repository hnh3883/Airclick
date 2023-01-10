using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPanelOut : MonoBehaviour
{
    public GameObject Manu_Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true)
        {
            Manu_Panel.SetActive(false);
        }
    }
}
