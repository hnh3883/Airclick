using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DS1 : MonoBehaviour
{
    public Transform hand;
    public Transform Me;


    public Transform Circle_Point;
    public Button btn;

    private int i = 0;
    private int j = 0;
    private Vector3 position_Change;
    private float position_Change2;
    private Vector3 position_Change3;
    public Sprite redone;

    public float speed = 0.5f;
    public float smoothTime = 0.3F;
    public float smoothTime2 = 0.5F;
    public float test;
    private Vector3 velocity = Vector3.zero;
    public Transform ade;
    public Transform coffee;
    public Transform tea;
    public Transform desert;
    public Transform coffee_scroll;
    public Transform tea_scroll;
    public Transform ade_scroll;
    public Transform desert_scroll;
    public Transform real_hand;
    public Transform canvas;

    public GameObject c1, c2, c3, c4, c5, c6;
    public GameObject t1, t2, t3, t4, t5, t6;
    public GameObject d1, d2, d3, d4, d5, d6;

    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite greySprtie;

    private SpriteRenderer spriteRenderer2;
    public Sprite newSprite2;
    public Sprite greySprtie2;

    //[RequireComponent(typeof(AudioSource))]
    // Start is called before the first frame    update
    AudioSource audioData;
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        //Debug.Log(audioData);

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer2 = Circle_Point.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            goright();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            goleft();
        }
        //Debug.Log(coffee_scroll.position.x);
        //Debug.Log(i + "/" + j + "/"+ (position_Change2 - transform.position.x));
        if (hand.gameObject.activeSelf == true)
        {
            position_Change = new Vector3(hand.position.x, hand.position.y, 90.0f);
            transform.position = Vector3.SmoothDamp(transform.position, position_Change, ref velocity, smoothTime);
        }

        /////////this is
        if (real_hand.gameObject.activeSelf == true && Circle_Point.localScale.x <= 1.5 && (coffee.gameObject.activeSelf == true || desert.gameObject.activeSelf == true|| tea.gameObject.activeSelf == true || ade.gameObject.activeSelf == true))
        {
            //Debug.Log(position_Change2 + "/" + transform.position.x);
            position_Change3 = new Vector3((position_Change2 - transform.position.x), 3.5f, 90f);
            //Debug.Log(position_Change3.x);
            

            if (position_Change3.x < -4)
            {
                
                goright();
                j = 1;

            }
            if (position_Change3.x > 3)
            {                
                
                goleft();
                j = 1;
            }

        }
        if (Circle_Point.localScale.x <= 0.9)
        {
            spriteRenderer.sprite = newSprite;
            spriteRenderer2.sprite = newSprite2;

        }
        else
        {
            spriteRenderer.sprite = greySprtie;
            spriteRenderer2.sprite = greySprtie2;

        }


    }

    void OnTriggerStay2D(Collider2D col)
    {
        
        //Debug.Log(col.gameObject.name);
        if (Circle_Point.localScale.x <= 1.5 && i == 0)
        {

            position_Change2 = transform.position.x;
            //Debug.Log(position_Change2);
            i = 1;
            j = 0;
        }
        if (Circle_Point.localScale.x > 1.5 && i == 1 && j == 0)
        {

            audioData.Play(0);
            btn = col.GetComponent<Button>();
            btn.onClick.Invoke();
            //Debug.Log(col.gameObject.name + "/" + btn.name);
            i = 0;

        }
        if (Circle_Point.localScale.x > 4 && i == 1 && j == 1)
        {
            i = 0;
            j = 0;

        }
    }
    void goright()
    {

        position_Change3 = new Vector3(-20.21f, 3.5f, 90f);

        if (coffee.gameObject.activeSelf == true)
        {
            c1.SetActive(true);
            c2.SetActive(true);
            c3.SetActive(true);
            c4.SetActive(true);
            c5.SetActive(true);
            c6.SetActive(true);
            coffee_scroll.transform.position = position_Change3;
        }
        if (tea.gameObject.activeSelf == true)
        {
            t1.SetActive(true);
            t2.SetActive(true);
            t3.SetActive(true);
            t4.SetActive(true);
            t5.SetActive(true);
            t6.SetActive(true);
            tea_scroll.transform.position = position_Change3;
        }
        if (desert.gameObject.activeSelf == true)
        {
            d1.SetActive(true);
            d2.SetActive(true);
            d3.SetActive(true);
            d4.SetActive(true);
            d5.SetActive(true);
            d6.SetActive(true);
            desert_scroll.transform.position = position_Change3;
        }
    }
    void goleft()
    {
        position_Change3 = new Vector3(-8.75f, 3.5f, 90f);
        if (coffee.gameObject.activeSelf == true)
        {
            c1.SetActive(false);
            c2.SetActive(false);
            c3.SetActive(false);
            c4.SetActive(false);
            c5.SetActive(false);
            c6.SetActive(false);

            coffee_scroll.transform.position = position_Change3;
        }
        else if (tea.gameObject.activeSelf == true)
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            tea_scroll.transform.position = position_Change3;
        }
        else if (desert.gameObject.activeSelf == true)
        {
            d1.SetActive(false);
            d2.SetActive(false);
            d3.SetActive(false);
            d4.SetActive(false);
            d5.SetActive(false);
            d6.SetActive(false);
            desert_scroll.transform.position = position_Change3;
        }
    }

}
