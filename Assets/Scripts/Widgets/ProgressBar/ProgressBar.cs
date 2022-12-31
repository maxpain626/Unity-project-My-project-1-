using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    [Header("Health stats")]
    [SerializeField] private Image imgFiller;
    [SerializeField] private int maxHealth = 100;
    public Collision2D collision;
    public int currentHealth;

    [Header("Take damage")]
    public int damageCount;


    public event Action<float> HealthChanged;

    public void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            ChangeHealth(damageCount);
        }
    }

    public void Update()
    {
        
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
        }
    }

    private void Death()
    {
        HealthChanged?.Invoke(0);
        Debug.Log("You are dead.");
        SceneManager.LoadScene(0);
    }
}
