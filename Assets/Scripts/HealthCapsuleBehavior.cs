using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCapsuleBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Вы излечились.");
        }
    }
}
