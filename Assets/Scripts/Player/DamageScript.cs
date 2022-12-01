using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public float damageCount = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerManager.Damage(damageCount);
    }
}
