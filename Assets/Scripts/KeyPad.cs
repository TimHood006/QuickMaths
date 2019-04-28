using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KeyPad : MonoBehaviour
{


    public bool Addition;
    public bool Subtraction;
    public bool Multiplication;
    public bool Division;
    public bool Modulus;



    // Text
    Text Text_Left;
    Text Text_Right;
    Text Text_Operator;
    public Text Text_Answer;

    // KeyPad Buttons
    public Button Key_1;
    public Button Key_2;
    public Button Key_3;
    public Button Key_4;
    public Button Key_5;
    public Button Key_6;
    public Button Key_7;
    public Button Key_8;
    public Button Key_9;
    public Button Key_0;
    public Button Key_Delete;
    public Button Key_Menu;

    // Member Vars
    public int m_ControlScheme;
    int m_NumberOfDigits;

    //EventSystem m_EventSystem = EventSystem.current;

    // Use this for initialization
    void Start()
    {
        m_ControlScheme = 1;

        //m_EventSystem = EventSystem.current;

        Addition = true;
        Subtraction = false;
        Multiplication = false;
        Division = false;
        Modulus = false;

    GetKeyPadButtons();
    }

    // Update is called once per frame
    void Update()
    {
        //if(EventSystem.current.currentSelectedGameObject.name.Equals("Button M"))
        //      {
        //          // Go to the main menu
        //          Text_Answer.text = Text_Answer.text + "M";
        //      }
    }

    void GetKeyPadButtons()
    {
        if (m_ControlScheme == 1)
        {
            Key_1 = GameObject.Find("Button 1").GetComponent<Button>();
            Key_2 = GameObject.Find("Button 2").GetComponent<Button>();
            Key_3 = GameObject.Find("Button 3").GetComponent<Button>();
            Key_4 = GameObject.Find("Button 4").GetComponent<Button>();
            Key_5 = GameObject.Find("Button 5").GetComponent<Button>();
            Key_6 = GameObject.Find("Button 6").GetComponent<Button>();
            Key_7 = GameObject.Find("Button 7").GetComponent<Button>();
            Key_8 = GameObject.Find("Button 8").GetComponent<Button>();
            Key_9 = GameObject.Find("Button 9").GetComponent<Button>();
            Key_0 = GameObject.Find("Button 0").GetComponent<Button>();
            Key_Delete = GameObject.Find("Button X").GetComponent<Button>();
            Key_Menu = GameObject.Find("Button M").GetComponent<Button>();

            Text_Answer = GameObject.Find("Answer Number").GetComponent<Text>();

            Key_1.onClick.AddListener(() => ButtonClicked(1));
            Key_2.onClick.AddListener(() => ButtonClicked(2));
            Key_3.onClick.AddListener(() => ButtonClicked(3));
            Key_4.onClick.AddListener(() => ButtonClicked(4));
            Key_5.onClick.AddListener(() => ButtonClicked(5));
            Key_6.onClick.AddListener(() => ButtonClicked(6));
            Key_7.onClick.AddListener(() => ButtonClicked(7));
            Key_8.onClick.AddListener(() => ButtonClicked(8));
            Key_9.onClick.AddListener(() => ButtonClicked(9));
            Key_0.onClick.AddListener(() => ButtonClicked(0));
            Key_Delete.onClick.AddListener(() => ButtonClicked(11));
            Key_Menu.onClick.AddListener(() => ButtonClicked(12));
        }
    }


    public void ButtonClicked(int ButtonNum)
    {
        if (ButtonNum >= 0 && ButtonNum <= 9)
        {
            Text_Answer.text = Text_Answer.text.ToString() + ButtonNum;
        }

        if (ButtonNum == 11)
        {
            Text_Answer.text = "";
        }

        if (ButtonNum == 12)
        {

        }

    }

    public void SetNumberOfDigits(int num)
    {
        m_NumberOfDigits = num;
    }
}
