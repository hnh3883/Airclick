﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelC3Script : MonoBehaviour
{
    public GameObject Panel2;

    public void ClosePanel()
    {
        if (Panel2 != null)
        {

            Panel2.SetActive(false);
        }

    }
}

