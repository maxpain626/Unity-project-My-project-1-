using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

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
