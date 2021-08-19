using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour {

    public Text a;
    public Image b;

    private void Start()
    {
        GameObject.Find("zvuk").transform.position = new Vector3(-9, 4);
        GameObject.Find("zvuk2").transform.position = new Vector3(-8.3f, 4);
        GameObject.Find("Exit").transform.position = new Vector3(9, 0);
    }

    public void Intellekt()
    {
        GameObject.Find("Main Camera").GetComponent<RandomCards>().playerChoise = 0;
        GameObject.Find("Main Camera").GetComponent<RandomCards>().ButtonsSetActive(false);
        b.gameObject.SetActive(true);
        b.gameObject.transform.position = new Vector3(-7, -3);
        a.text = "Интеллект!";
        Debug.Log(a.text);
        PlayerMove();
        ComputerMove();
        GameObject.Find("Main Camera").GetComponent<RandomCards>().WhoWin();
    }
    public void Sila()
    {
        GameObject.Find("Main Camera").GetComponent<RandomCards>().playerChoise = 1;
        GameObject.Find("Main Camera").GetComponent<RandomCards>().ButtonsSetActive(false);
        b.gameObject.SetActive(true);
        b.gameObject.transform.position = new Vector3(-7, -3);
        a.text = "Сила!";
        PlayerMove();
        ComputerMove();
        GameObject.Find("Main Camera").GetComponent<RandomCards>().WhoWin();
    }
    public void Skorost()
    {
        GameObject.Find("Main Camera").GetComponent<RandomCards>().playerChoise = 2;
        GameObject.Find("Main Camera").GetComponent<RandomCards>().ButtonsSetActive(false);
        b.gameObject.SetActive(true);
        b.gameObject.transform.position = new Vector3(-7, -3);
        a.text = "Скорость и ловкость!";
        PlayerMove();
        ComputerMove();
        GameObject.Find("Main Camera").GetComponent<RandomCards>().WhoWin();
    }
    public void Osobie()
    {
        GameObject.Find("Main Camera").GetComponent<RandomCards>().playerChoise = 3;
        GameObject.Find("Main Camera").GetComponent<RandomCards>().ButtonsSetActive(false);
        b.gameObject.SetActive(true);
        b.gameObject.transform.position = new Vector3(-7, -3);
        a.text = "Особые умения!!";
        PlayerMove();
        ComputerMove();
        GameObject.Find("Main Camera").GetComponent<RandomCards>().WhoWin();
    }
    public void Boytsovskie()
    {
        GameObject.Find("Main Camera").GetComponent<RandomCards>().playerChoise = 4;
        GameObject.Find("Main Camera").GetComponent<RandomCards>().ButtonsSetActive(false);
        b.gameObject.SetActive(true);
        b.gameObject.transform.position = new Vector3(-7, -3);
        a.text = "Бойцовские навыки!";
        PlayerMove();
        ComputerMove();
        GameObject.Find("Main Camera").GetComponent<RandomCards>().WhoWin();
    }

    void PlayerMove()
    {
        StaticClass.t1 = false;
        int n = GameObject.Find("Main Camera").GetComponent<RandomCards>().playercards[StaticClass.ip];
        GameObject.Find(n.ToString() + "(Clone)").tag = "middle";
        GameObject.Find("фон").transform.parent = null;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().card = GameObject.Find(n.ToString() + "(Clone)");
        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress = 0;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition = new Vector2(0, -3);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition = new Vector2(4, 0);
        GameObject.Find(n.ToString() + "(Clone)").transform.localScale = new Vector3(1, 1);
    }
    void ComputerMove()
    {
        int n = GameObject.Find("Main Camera").GetComponent<RandomCards>().computercards[StaticClass.ic];
        GameObject.Find(n.ToString() + "(Clone)").GetComponent<SpriteRenderer>().sprite = GameObject.Find("Main Camera").GetComponent<RandomCards>().textures[n];
        GameObject.Find(n.ToString() + "(Clone)").tag = "middle";
        GameObject.Find("Main Camera").GetComponent<MoveCard>().card1 = GameObject.Find(n.ToString() + "(Clone)");
        GameObject.Find("Main Camera").GetComponent<MoveCard>().progress1 = 0;
        GameObject.Find("Main Camera").GetComponent<MoveCard>().startPosition1 = new Vector2(0, 3);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().endPosition1 = new Vector2(-4, 0);
        GameObject.Find("Main Camera").GetComponent<MoveCard>().step = 0.02f;
        GameObject.Find(n.ToString() + "(Clone)").transform.localScale = new Vector3(1, 1);
    }
    public void OffAudio()
    {
        GameObject.Find("Audio Source").GetComponent<AudioSource>().volume = 0;
    }
    public void OnAudio()
    {
        GameObject.Find("Audio Source").GetComponent<AudioSource>().volume = 0.1f;
    }
    public void Vmenu()
    {
        Application.LoadLevel(0);
        Destroy(GameObject.Find("Audio Source"));
    }
}
