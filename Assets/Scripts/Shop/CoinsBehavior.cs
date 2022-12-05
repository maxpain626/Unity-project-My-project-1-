using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CoinsText.Coins += 1;
            Destroy(gameObject);
        }
        //else if (collision.gameObject.tag == "Enemy")
        //{
        //    Physics2D.IgnoreCollision();
        //}
    }
}
