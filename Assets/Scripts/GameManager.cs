﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject ButtonConnect;
    public GameObject ButtonHost;
    public GameObject ButtonBack;
    public GameObject mainMenu;
    public GameObject serverMenu;
    public GameObject connectMenu;
    public GameObject ServerPrefab;
    public GameObject ClientTCPPrefab;
    public static bool isActive = true;

    public static GameManager Instance { set; get; }
    // Start is called before the first frame update
    public void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        connectMenu.SetActive(false);

        Host(() => {
            try
            {
                Server s = Instantiate(ServerPrefab).GetComponent<Server>();
                s.Init();

                ClientTCP c = Instantiate(ClientTCPPrefab).GetComponent<ClientTCP>();
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        });
        Back(() => {
            Global.WinnerInt = -1;
            SceneManager.LoadScene("MultiplayerScene");
        });
        Connect(() => {
            string hostAddress = GameObject.Find("HostInput").GetComponent<TMP_InputField>().text;
            if(hostAddress == "")
            {
                hostAddress = "127.0.0.1";
            }

            try
            {
                ClientTCP c = Instantiate(ClientTCPPrefab).GetComponent<ClientTCP>();
                c.Connect();
                Debug.Log("by connect button");
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        });
    }

    // Update is called once per frame
    public void Connect(UnityAction action)
    {
        ButtonConnect.GetComponentInChildren<Button>().onClick.AddListener(action);
    }

    public void Host(UnityAction action)
    {
        ButtonHost.GetComponentInChildren<Button>().onClick.AddListener(action);
    }

    public void Back(UnityAction action)
    {
        GameObject.Find("ButtonBack").GetComponent<Button>().onClick.AddListener(action);
        //this.isActive = false;
    }

    public static void StartGame()
    {
        GameManager.isActive = false;
        Debug.Log("in scee");
        SceneManager.LoadScene("MultiPlayerScene");
    }

    public void Update()
    {
        GameObject.Find("CanvasServerMenu").SetActive(GameManager.isActive);
    }
}