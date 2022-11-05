using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    private float vInput;
    private float hInput;

    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * moveSpeed;
        this.transform.Translate(Vector2.up * vInput * Time.deltaTime);
        this.transform.Translate(Vector2.right * hInput * Time.deltaTime);
    }
}
