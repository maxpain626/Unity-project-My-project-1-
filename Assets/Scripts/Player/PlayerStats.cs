using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public event Action<float> OnPlayerHealthValueChangedEvent;

    [SerializeField] private int healthDefault = 100;
    [SerializeField] private Collision2D collision;

    public int health { get; private set; }
    public float healthNormalized => (float)this.health / this.healthDefault;

    private void Awake()
    {
        this.health = this.healthDefault;
    }

    private void Update()
    {
        if (collision.gameObject.tag == "Bomb")
        {
            this.HitPlayer();
        }
    }

    private void HitPlayer()
    {
        this.health -= 5;
        if (this.health <= 0)
            Destroy(this.gameObject);

        this.OnPlayerHealthValueChangedEvent?.Invoke(this.healthNormalized);
    }
}
