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
                Debug.Log("�������");
                break;
            case "Attack":
                Debug.Log("� ������!");
                break;
            default:
                Debug.Log("����������� ����.");
                break;
        }
    }

 
    void Update()
    {
        
    }
}
