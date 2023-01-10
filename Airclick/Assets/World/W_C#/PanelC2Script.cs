using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelC2Script : MonoBehaviour
{
    public GameObject Panel1;

    public void ClosePanel()
    {
        if (Panel1 != null)
        {

            Panel1.SetActive(false);
        }

    }
}

