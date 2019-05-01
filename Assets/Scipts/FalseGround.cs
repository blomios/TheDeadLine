using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseGround : Trap
{

    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
    }
}
