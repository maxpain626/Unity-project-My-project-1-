using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAction : MonoBehaviour
{

    void Start()
    {
        string characterAction = "Attack";


    switch (characterAction)
        {
            case "Heal":
                Debug.Log("Лечение");
                break;
            case "Attack":
                Debug.Log("К оружию!");
                break;
            default:
                Debug.Log("Приготовить щиты.");
                break;
        }
    }

 
    void Update()
    {
        
    }
}
