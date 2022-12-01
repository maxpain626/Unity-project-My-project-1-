using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySuriken : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Suriken")
        {
            Destroy(gameObject);
        }
    }
}
