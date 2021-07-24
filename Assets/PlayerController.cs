using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            rb.velocity = new Vector2(-5, rb.velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            rb.velocity = new Vector2(5, rb.velocity.y);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.velocity = new Vector2(rb.velocity.x, 10);

        }


    }
}
