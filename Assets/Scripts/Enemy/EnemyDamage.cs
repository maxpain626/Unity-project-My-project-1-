using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //private bool isActive = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            Debug.Log("Получай!");
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
