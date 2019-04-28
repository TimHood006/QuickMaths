using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{

    public Canvas Canvas_MainMenu;
    public Canvas Canvas_Game;
    public Canvas Canvas_Options;
    public Canvas Canvas_Controls;
    public Canvas Canvas_Stats;

    public Button Button_PlayStart;
    Button Button_OptionsStart;

    KeyPad m_KeyPad;
    Options m_Options;


    // Use this for initialization
    void Start()
    {
        GetGameObjects();

        // Disable unsed canvases
        Canvas_Game.enabled = false;
        Canvas_Options.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GetGameObjects()
    {
        Canvas_MainMenu = GameObject.Find("Main Menu").GetComponent<Canvas>();
        //Canvas_Game = GameObject.Find("Game").GetComponent<Canvas>();
        //Canvas_Options = GameObject.Find("Options").GetComponent<Canvas>();
        // Canvas_Controls = GameObject.Find("Main Menu").GetComponent<Canvas>();
        // Canvas_Stats = GameObject.Find("Main Menu").GetComponent<Canvas>();

        Button_PlayStart = GameObject.Find("Play Button Whole Screen").GetComponent<Button>();
        Button_OptionsStart = GameObject.Find("Start Button").GetComponent<Button>();

        m_KeyPad = Canvas_Game.GetComponent<KeyPad>();
        m_Options = Canvas_Game.GetComponent<Options>();


        Button_PlayStart.onClick.AddListener(() => ButtonClicked(1));
        Button_OptionsStart.onClick.AddListener(() => ButtonClicked(2));
    }

    public void ButtonClicked(int ButtonNum)
    {
        if(ButtonNum == 1)
        {
            // Go to options
            Canvas_MainMenu.enabled = false;
            Canvas_Options.enabled = true;
        }
        else if (ButtonNum == 2)
        {
            // Start the game
            Canvas_Options.enabled = false;
            Canvas_Game.enabled = true;
            m_KeyPad.SetNumberOfDigits(m_Options.GetNumberOfDigits());
        }
    }
}