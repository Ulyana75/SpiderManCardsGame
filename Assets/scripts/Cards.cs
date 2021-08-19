using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{

    public int i, sila, sl, ou, bn;

    public int WhoMore(int pl1, int pl2)
    {
        int k = 0;
        if (pl1 > pl2) k = 1;
        if (pl1 < pl2) k = 2;
        if (pl1 == pl2) k = 3;
        return k;
    }


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

