using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseMover : MonoBehaviour
{
    [SerializeField] private Vector2 direction;
    [SerializeField] private float acceleration;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(direction.normalized * acceleration, ForceMode2D.Impulse);
        }
    }
}
