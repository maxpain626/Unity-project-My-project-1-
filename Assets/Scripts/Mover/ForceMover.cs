using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMover : MonoBehaviour
{
    [SerializeField] private Vector2 direction;
    [SerializeField] private float acceleration;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(direction.normalized * acceleration);
    }
}
