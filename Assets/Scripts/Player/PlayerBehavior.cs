using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [Header("Movement")]
    [Space(height:2)]

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] private Joystick _joystick;
    public LayerMask groundLayer;

    [Header("Attack")]
    [Space(height: 2)]

    [SerializeField] private GameObject suriken;
    [SerializeField] private float surikenSpeed = 100f;

    [Header("Sounds")]
    [Space(height: 2)]

    [SerializeField] AudioSource coinsSound;

    private float moveInput;
    private Vector2 _inputVector;
    private bool jumpHero = false;
    private Rigidbody2D body;
    private KeyCode jumpButton = KeyCode.Space;
    private Animator animator;
    private Collider2D collider2d;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();

        CoinsText.Coins = 0;
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            jumpHero = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ground")
        {
            jumpHero = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coins")
        {
            CoinsText.Coins += 1;
            coinsSound.Play();
            //animator.SetTrigger("coinsTake");
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(jumpButton) && jumpHero == true)
        {
            body.velocity = new Vector2(0, jumpForce);
        }
    }

    void Update()
    {
        moveCharacter(new Vector2(_joystick.Horizontal, 0));

        if ((_inputVector.x) < 0) // если двигается влево
        {
            animator.SetTrigger("axisBoolLeft");
            GetComponent<SpriteRenderer>().flipX = true;
        }

        else if ((_inputVector.x) > 0) // если двигается вправо
        {
            animator.SetTrigger("axisBoolLeft");
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    
    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    public void JumpHero()
    {
        if (jumpHero == true)
        {
            body.velocity = new Vector2(0, jumpForce);
        }
    }

    public void strikeSuriken()
    {
        GameObject newSuriken = Instantiate(suriken, this.transform.position + new Vector3(0, 1, 0), this.transform.rotation) as GameObject;

        Rigidbody2D surikenRB = newSuriken.GetComponent<Rigidbody2D>();

        surikenRB.velocity = this.transform.up * surikenSpeed;
    }
}
