using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecieveDamage : MonoBehaviour
{
    public GameObject slider;
    public Image imgFiller;
    private ProgressBar progressBar;

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
