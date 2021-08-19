using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCard : MonoBehaviour {

    public Vector2 startPosition, endPosition, startPosition1, endPosition1;
    public float step = 0.05f;
    public float progress, progress1;
    public GameObject card, card1;

    // Use this for initialization
    void Start () {
        card = new GameObject();
        card1 = new GameObject();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        card.transform.position = Vector2.Lerp(startPosition, endPosition, progress);
        progress += step;
        card1.transform.position = Vector2.Lerp(startPosition1, endPosition1, progress1);
        progress1 += step;
	}
}
