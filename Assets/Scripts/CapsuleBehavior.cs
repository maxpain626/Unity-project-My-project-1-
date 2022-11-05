using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleBehavior : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        this.transform.Translate(Vector2.up * moveSpeed * Time.fixedTime);
    }
}
