using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplotionTrigger : MonoBehaviour
{
    public float delay = 0f;
    private Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator = GetComponent<Animator>();

        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("explotionTrigger");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            Debug.Log("Booom!");
        }
    }
}
