using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerEvents : MonoBehaviour
{
    //public delegate void MeDelegate();
    //public event MeDelegate meEvent;

    public static Action onTouched;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (onTouched != null)
        //{
        //    onTouched.Invoke();
        //}

        onTouched?.Invoke();
        Debug.Log("Я ударился!");
    }
}
