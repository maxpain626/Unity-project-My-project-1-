using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplotionTrigger : MonoBehaviour
{
    public float delay = 0f;
    private Animator animator;

    [SerializeField] AudioSource boomSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator = GetComponent<Animator>();

        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("explotionTrigger");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            boomSound.Play();
            Debug.Log("Booom!");
        }
        else if (collision.gameObject.tag == "Suriken")
        {
            animator.SetTrigger("explotionTrigger");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            boomSound.Play();
            Debug.Log("Booom!");
        }
        else if (collision.gameObject.tag == "Ground")
        {
            animator.SetTrigger("explotionTrigger");
            Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
            boomSound.Play();
            Debug.Log("Booom!");
        }
    }
}
