using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEnemy : MonoBehaviour
{
    public static int Enemies;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        text.text = ("Enemies: " + Enemies.ToString());
    }
}
