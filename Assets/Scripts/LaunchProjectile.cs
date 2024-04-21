using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    [Tooltip("Used to instantiate and fire at the player")][SerializeField] GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            GameObject newProjectile = (GameObject)Instantiate(projectile, transform.position, quaternion.identity);
            Destroy(newProjectile, 3);
        }
    }
}
