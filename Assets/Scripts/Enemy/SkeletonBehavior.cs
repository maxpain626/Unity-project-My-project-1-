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
        this.GetComponent<BoxCollider2D>().offset = new Vector2(0,0);

        transform.position = new Vector2(0, 1);

        transform.position += new Vector3(-1, 2, -1);

    }

    void Update()
    {
        transform.position += new Vector3(-0.1f, 0.6f, 0) * Time.deltaTime;
    }
}
