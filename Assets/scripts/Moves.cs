using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moves : MonoBehaviour {

    public Text a;
    float x = 1, y = 1;
    
    void Start() {

        //a.text = "Интеллект: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[GameObject.Find("Main Camera").GetComponent<RandomCards>().playercards[StaticClass.ip]].i.ToString() + "\nСила: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[GameObject.Find("Main Camera").GetComponent<RandomCards>().playercards[StaticClass.ip]].sila.ToString() + "\nСкорость и ловкость: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[GameObject.Find("Main Camera").GetComponent<RandomCards>().playercards[StaticClass.ip]].sl.ToString() + "\nОсобые умения: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[GameObject.Find("Main Camera").GetComponent<RandomCards>().playercards[StaticClass.ip]].ou.ToString() + "\nБойцовские навыки: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[GameObject.Find("Main Camera").GetComponent<RandomCards>().playercards[StaticClass.ip]].bn.ToString();
        //a.text = "Интеллект: " + "\nСила:";
        //a.gameObject.SetActive(false);
    }

    void OnMouseOver()
    {
        if ((gameObject.tag == "player") && (StaticClass.t1))
        {
            int n = GameObject.Find("Main Camera").GetComponent<RandomCards>().playercards[StaticClass.ip];
            GameObject.Find("фон").GetComponent<TextMesh>().text = "Интеллект: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[n].i.ToString() + "\nСила: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[n].sila.ToString() + "\nСкорость и ловкость: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[n].sl.ToString() + "\nОсобые умения: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[n].ou.ToString() + "\nБойцовские навыки: " + GameObject.Find("Main Camera").GetComponent<RandomCards>().kard[n].bn.ToString();
            string s = n.ToString();
            GameObject.Find("фон").transform.position = new Vector3(5.37f, -3);
            GameObject.Find("фон").transform.localScale = new Vector3(0.086f, 0.094f);
            GameObject.Find(s + "(Clone)").transform.localScale = new Vector3(x * 2, y * 2);
            GameObject.Find(s + "(Clone)").transform.position = new Vector3(0, -1.2f);
            GameObject.Find("фон").transform.SetParent(GameObject.Find(s + "(Clone)").transform);
            GameObject.Find("фон").transform.position = new Vector3(2.8f, -2.2f);
        }
        if ((StaticClass.b == 0) && (StaticClass.t1))
        {
            int n = GameObject.Find("Main Camera").GetComponent<RandomCards>().computercards[StaticClass.ic];
            if (gameObject.name == n.ToString() + "(Clone)")
            {
                GameObject.Find(n.ToString() + "(Clone)").transform.localScale = new Vector3(x * 2, y * 2);
            }
        }
    }
    void OnMouseExit()
    {
        string s = GameObject.Find("Main Camera").GetComponent<RandomCards>().playercards[StaticClass.ip].ToString();
        GameObject.Find("фон").transform.position = new Vector3(100, 100);
        GameObject.Find(s + "(Clone)").transform.localScale = new Vector3(x, y);
        if(StaticClass.t1) GameObject.Find(s + "(Clone)").transform.position = new Vector3(0, -3);
        if (StaticClass.b == 0)
        {
            int n = GameObject.Find("Main Camera").GetComponent<RandomCards>().computercards[StaticClass.ic];
            if (gameObject.name == n.ToString() + "(Clone)") {
                GameObject.Find(n.ToString() + "(Clone)").transform.localScale = new Vector3(x, y);
            }
        }
    }



}
