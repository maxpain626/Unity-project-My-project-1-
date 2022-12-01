using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurikenBehavior : MonoBehaviour
{
    public float onScreenDelay = 3f;

    public void Start()
    {
        Destroy(this.gameObject, onScreenDelay);
    }
}
