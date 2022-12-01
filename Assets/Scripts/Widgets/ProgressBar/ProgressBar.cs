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
    private int currentHealth;

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

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeHealth(10);
        }
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
    }
}
