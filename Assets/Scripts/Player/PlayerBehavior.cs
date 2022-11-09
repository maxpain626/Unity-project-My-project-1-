using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float addForce = 10f;
    public enum ProjectAxis { onlyX = 0, xAndY = 1 };
    public ProjectAxis projectAxis = ProjectAxis.onlyX;
    public bool isFacingRight = true;
    private bool jumpHero = false;
    private float rotationY;
    private Rigidbody2D body;
    public KeyCode addForceButton = KeyCode.Space;
    private Vector2 direction;
    private float vertical;
    private float horizontal;

    public float delay = 0f;
    private Animator animator;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
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

    private void FixedUpdate()
    {
        body.AddForce(direction * body.mass * moveSpeed);
        if (Mathf.Abs(body.velocity.x) > moveSpeed / 100f)
        {
            body.velocity = new Vector2(body.velocity.x, Mathf.Sign(body.velocity.y) * moveSpeed / 100f);
        }
        else
        {
            if(Input.GetKey(addForceButton) && jumpHero)
            {
                body.velocity = new Vector2(0, addForce);
            }
        }
    }

    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        if(Input.GetAxis("Horizontal") < 0) // если двигается влево
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if(Input.GetAxis("Horizontal") < 0) // если двигается вправо
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
