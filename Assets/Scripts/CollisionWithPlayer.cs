using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayer : MonoBehaviour
{
    public int Score{ get; private set; }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PickMe")
        {
            Score++;
            Destroy(collision.gameObject);
        }
    }
}
