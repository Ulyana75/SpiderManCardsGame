using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour {

    public void NewGame()
    {
        Application.LoadLevel(4);
        DontDestroyOnLoad(GameObject.Find("Audio Source"));
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Vmenu()
    {
        Application.LoadLevel(0);
        Destroy(GameObject.Find("Audio Source"));
    }
    public void Spravka()
    {
        Application.LoadLevel(5);
        Destroy(GameObject.Find("Audio Source"));
    }

}
