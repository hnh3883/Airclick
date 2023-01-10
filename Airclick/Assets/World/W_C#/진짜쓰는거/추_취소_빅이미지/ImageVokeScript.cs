using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageVokeScript : MonoBehaviour
{
    public GameObject[] arrayObject;
    public Button addbtn;
    public int arraySize = 12;
    //public string world33;
    // public Image myImage;

    void Start()
    {
        addbtn = this.transform.GetComponent<Button>();

        //arrayObject[0] = GameObject.Find("BigAme");
        //arrayObject[1] = GameObject.Find("BigCfl");

        //world33 = arrayObject[1].name.ToString();

        //Debug.Log("클릭 디버깅 :: " + world33);

        addbtn.onClick.AddListener(ClosedPanel2);

   }

    public void ClosedPanel2()
    {
       

        for (int i = 0; i< 12; i++)
        {
            bool isActive = arrayObject[i].activeSelf;


            if (isActive == true)
            {
                arrayObject[i].SetActive(!isActive);
                //Debug.Log("클릭 디버깅 :: " + i);
            }
            
        }
    }

}
