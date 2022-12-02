using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    private int _coinsCollected;
    private float _playerHP = 100f;
    private string _firstName;

    public int Coins
    {
        get
        {
            return _coinsCollected;
        }

        set
        {
            _coinsCollected = value;
            Debug.LogFormat("Coins: {0}", _coinsCollected);
        }
    }

    private float PlayerHP
    {
        get
        {
            return _playerHP = 100f;
        }
        set
        {
            _playerHP = value;
            Debug.LogFormat("HealthPoints: {0}", _playerHP);
        }
    }
}
