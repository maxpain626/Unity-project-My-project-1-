using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour
{
    public static int Coins;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        text.text = ("Coins: " + Coins.ToString());
    }
}
