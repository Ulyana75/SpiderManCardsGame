using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Polzunok : MonoBehaviour {

    public Text a;
    public GameObject l;
    public Text b;

    void Start()
    {
        b.gameObject.SetActive(false);
        l.SetActive(false);
    }

    public void SliderChange(float f)
    {
        StaticClass.k = f;
        a.text = f.ToString();
    }
    public void ForButton()
    {
        Application.LoadLevel(1);
        l.SetActive(true); b.gameObject.SetActive(true);
        DontDestroyOnLoad(GameObject.Find("Audio Source"));
    }
}
