using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spades: Trap
{
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        if (collision.gameObject.tag == "Player" && isActive)
        {
            Debug.Log("player");
            animator.SetTrigger("Enter");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && isActive)
        {
            animator.SetTrigger("Exit");
        }
    }
}
