using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [Header("Health stats")]
    [SerializeField] private Image imgFiller;
    [SerializeField] private float maxHealth = 100f;
    private float currentHealth;

    /*
    public void SetValue(float valueNormalized)
    {
        this.imgFiller.fillAmount = valueNormalized;

        var valueInPercent = Mathf.RoundToInt(f: valueNormalized * 100f);
    }
    */

    public void Start()
    {
        currentHealth = maxHealth;
    }

    public void Update()
    {
        
    }
}
