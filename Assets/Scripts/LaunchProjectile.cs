using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    [Header("General")]
    [Tooltip("Used to instantiate and fire at the player")][SerializeField] GameObject projectile;
    [Tooltip("The target to shoot at")][SerializeField] Transform target;

    [Header("Projectile Control")]
    [Tooltip("Used to modify the speed at which the projectile travels")][SerializeField] float projectileSpeed = 1500f;
    [Tooltip("Used to control the rate of fire")][SerializeField] float reloadSpeed = 2.0f;
    float timer = 0;// used in combination with the reload speed variable to contol the rate of fire

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        CheckTimer();
    }

    void CheckTimer()
    {
        timer += Time.deltaTime;
        if(timer >= reloadSpeed)
        {
            FireProjectile();
            timer = 0;
        }
    }

    private void FireProjectile()
    {
        GameObject newProjectile = (GameObject)Instantiate(projectile, transform.position, quaternion.identity);
        newProjectile.transform.LookAt(target);
        newProjectile.GetComponent<Rigidbody>().AddForce(Vector3.forward * projectileSpeed);
        Destroy(newProjectile, 3);
    }
}
