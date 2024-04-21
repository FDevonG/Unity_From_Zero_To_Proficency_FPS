using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionWithProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] explosions = new GameObject[] {};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player"){
            Destroy(collision.gameObject, 1);
        }
        int randomNumnber = UnityEngine.Random.Range(0, explosions.Length);
        Instantiate(explosions[randomNumnber], transform.position, quaternion.identity);
    }
}
