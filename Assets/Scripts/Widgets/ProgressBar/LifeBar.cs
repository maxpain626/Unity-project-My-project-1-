using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField] private Image healthBarFilling;

    [SerializeField] private ProgressBar health;

    private void Awake()
    {
        health.HealthChanged += OnHealthChanged;
    }

    private void OnDestroy()
    {
        health.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float valueAsPercentage)
    {
        healthBarFilling.fillAmount = valueAsPercentage;
    }
}
