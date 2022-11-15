using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMover : MonoBehaviour
{
    [SerializeField] private Vector2 startPosition;
    [SerializeField] private Vector2 endPosition;
    [SerializeField] private float stepPosition;
    private float progressPosition;

    void Start()
    {
        transform.position = startPosition;
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.Lerp(startPosition, endPosition, progressPosition);
        progressPosition += stepPosition;
    }
}
