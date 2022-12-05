using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsBehavior : MonoBehaviour
{
    public AudioSource coinsSound;

    private void Start()
    {
        CoinsText.Coins = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CoinsText.Coins += 1;
            coinsSound.Play();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Money!");
        }
    }
}
