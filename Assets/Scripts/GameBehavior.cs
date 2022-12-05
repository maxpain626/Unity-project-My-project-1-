using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    private int coinsCollected = 0;
    private float playerHP = 100f;
    private string firstName;

    public int Coins
    {
        get
        {
            return coinsCollected;
        }

        set
        {
            coinsCollected = value;
            Debug.LogFormat("Coins: {0}", coinsCollected);
        }
    }

    private float PlayerHP
    {
        get
        {
            return playerHP = 100f;
        }
        set
        {
            playerHP = value;
            Debug.LogFormat("HealthPoints: {0}", playerHP);
        }
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }
}
