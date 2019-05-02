using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject gameOverObject;

    public bool isDead;

    private void Start()
    {
        isDead = false;
    }

    public void death()
    {
        isDead = true;
        gameOverObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Trap")
        {
            death();
        }
    }
}
