using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardProccessing : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    float timer;
    public float seconds;
    public GameObject one1;
    public GameObject one2;
    public GameObject one3;
    public GameObject Main;

    public GameObject audio1;
    public GameObject audio2;


    // Start is called before the first frame update
    void Start()
    {
        audio1.SetActive(false);
        audio2.SetActive(false);
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= seconds)
        {
            gameObject.GetComponent<Image>().sprite = sprite1;
            audio1.SetActive(true);
        }
        if (timer >= seconds+1f)
        {
            one1.SetActive(true);
       
        }
        if (timer >= seconds + 2f)
        {
            one2.SetActive(true);
        }
        if (timer >= seconds + 3f)
        {
            one3.SetActive(true);
        }
        if (timer >= seconds+5f)
        {
            gameObject.GetComponent<Image>().sprite = sprite2;
            audio2.SetActive(true);

            one1.SetActive(false);
            one2.SetActive(false);
            one3.SetActive(false);

        }
        if (timer >= seconds + 11f)
        {
            timer = 0f;
            gameObject.SetActive(false);
            Main.SetActive(true);
            gameObject.GetComponent<Image>().sprite = sprite3;

        }
    }
}
