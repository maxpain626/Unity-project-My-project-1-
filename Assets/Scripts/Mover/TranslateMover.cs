using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMover : MonoBehaviour
{
    [SerializeField] private Vector2 direction;
    [SerializeField] private float moveSpeed;

    void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.Translate(direction.normalized * moveSpeed);
    }
}