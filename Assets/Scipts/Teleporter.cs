using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Teleporter teleporterTarget;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(teleporterTarget)
                collision.gameObject.transform.position = teleporterTarget.transform.position;
        }
    }
}
