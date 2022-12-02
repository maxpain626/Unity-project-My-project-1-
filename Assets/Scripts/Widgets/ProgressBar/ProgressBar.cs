using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ProgressBar : MonoBehaviour
{
    [Header("Health stats")]
    [SerializeField] private Image imgFiller;
    [SerializeField] private int maxHealth = 100;
    public Collision2D collision;
    public int currentHealth;
    public GameObject bomb;

    /*
    public void SetValue(float valueNormalized)
    {
        this.imgFiller.fillAmount = valueNormalized;

        var valueInPercent = Mathf.RoundToInt(f: valueNormalized * 100f);
    }
    */

    public event Action<float> HealthChanged;

    public void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            ChangeHealth(10);
            Update();
        }
    }

    public void Update()
    {
        /*if (collision.gameObject == bomb)
        {
            ChangeHealth(10);
        }*/
    }

    public void ChangeHealth(int value)
    {
        currentHealth -= value;

        if (currentHealth <= 0)
        {
            Death();
        }
        else
        {
            float currentHealthPercentage = (float)currentHealth / maxHealth;
            HealthChanged?.Invoke(currentHealthPercentage);
            Debug.Log("progressBar F else");
        }
    }

    private void Death()
    {
        HealthChanged?.Invoke(0);
        Debug.Log("You are dead.");
    }
}
