using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Options : MonoBehaviour {

    Button Button_DigitUp;
    Button Button_DigitDown;

    Text Text_NumDigits;
   

    public int m_NumberOfDigits;


	// Use this for initialization
	void Start ()
    {
        SetupObjects();

        m_NumberOfDigits = 2;

        Text_NumDigits.text = m_NumberOfDigits.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void SetupObjects()
    {
        Button_DigitUp = GameObject.Find("Digit Up").GetComponent<Button>();
        Button_DigitDown = GameObject.Find("Digit Down").GetComponent<Button>();

        Button_DigitUp.onClick.AddListener(() => ButtonClicked(0));
        Button_DigitDown.onClick.AddListener(() => ButtonClicked(1));


        Text_NumDigits = GameObject.Find("Digits Number").GetComponent<Text>();
    }

    void ButtonClicked(int ButtonNum)
    {
        if(ButtonNum == 0)
        {
            m_NumberOfDigits++;
            Text_NumDigits.text = m_NumberOfDigits.ToString();
        }
        else if (ButtonNum == 1)
        {
            m_NumberOfDigits--;
            Text_NumDigits.text = m_NumberOfDigits.ToString();
        }
    }


    public int GetNumberOfDigits()
    {
        return m_NumberOfDigits;
    }
}
