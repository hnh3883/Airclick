using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DS2 : MonoBehaviour
{

    public Transform hand;
    public Transform circle;
    private Vector3 position_Change;
    private Vector3 default_Position;
    public float circle_speed = 0.2f;
    public float stabilibation = 0.1f;
    public float circle_max = 4;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        default_Position = new Vector3(hand.position.x, hand.position.y, hand.position.z);
        spriteRenderer = GetComponent<SpriteRenderer>();

    }


    // Update is called once per frame
    void Update()
    {
        Color color = spriteRenderer.color;
        position_Change = new Vector3(hand.position.x, hand.position.y, hand.position.z);
        if (position_Change.z - default_Position.z >= stabilibation)
        {
            default_Position = position_Change;
            if (transform.localScale.x >= 0.2)
            {
                transform.localScale -= new Vector3(circle_speed, circle_speed, 0);
                
                    if (color.a <= 0.9f)
                {
                    color.a += 0.04f;
                    spriteRenderer.color = color;
                }
            }
        }
        else if (default_Position.z - position_Change.z >= stabilibation)
        {
            default_Position = position_Change;

            if (transform.localScale.x <= circle_max + 1)
            {
                transform.localScale += new Vector3(circle_speed, circle_speed, 0);

                if (color.a >= 0.0f)
                {
                    color.a -= 0.04f;
                    spriteRenderer.color = color;
                }
            }
        }
       
        
       
    }
    


}
