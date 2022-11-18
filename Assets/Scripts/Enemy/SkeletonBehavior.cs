using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonBehavior : MonoBehaviour
{
    [SerializeField] private float timeLerp;
    [SerializeField] private Vector2 firstPosition;
    [SerializeField] private Vector2 secondPosition;

    void Start()
    {
        GetComponent<BoxCollider2D>().offset = Vector2.Lerp(firstPosition, secondPosition, 1);


    }

    void Update()
    {
        
    }
}
