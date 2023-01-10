using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPrefsArrayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] number = new int[100]; // 정수형 배열 생성

        number[0] = 0;
        number[1] = 0;
        number[2] = 0;

        string strArr = ""; // 문자열 생성

        for (int i = 0; i < number.Length; i++) // 배열과 ','를 번갈아가며 tempStr에 저장
        {
            strArr = strArr + number[i];
            if (i < number.Length - 1) // 최대 길이의 -1까지만 ,를 저장
            {
                strArr = strArr + ",";
            }
        }

        //print(strArr); // 0,0,0 으로 저장된 strArr

        PlayerPrefs.SetString("Data", strArr); // PlyerPrefs에 문자열 형태로 저장
                                               ////// 불러오기

        string[] dataArr = PlayerPrefs.GetString("Data").Split(','); // PlayerPrefs에서 불러온 값을 Split 함수를 통해 문자열의 ,로 구분하여 배열에 저장


        int[] number2 = new int[dataArr.Length]; // 문자열 배열의 크기만큼 정수형 배열 생성

        for (int i = 0; i < dataArr.Length; i++)
        {
            number2[i] = System.Convert.ToInt32(dataArr[i]); // 문자열 형태로 저장된 값을 정수형으로 변환후 저장
            print(number2[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
