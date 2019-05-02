using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupGround : MonoBehaviour
{
    [SerializeField] SpriteRenderer renderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            renderer.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            renderer.enabled = false;
        }
    }
}
