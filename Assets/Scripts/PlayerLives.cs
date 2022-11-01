using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    void Start()
    {

        int playerLives = 3;

        while (playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }
        Debug.Log("Player KO'd...");
    }

    void Update()
    {
        
    }
}
