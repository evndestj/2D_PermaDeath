using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform shotPoint;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // shooting logic
        Instantiate (projectilePrefab, shotPoint.position, shotPoint.rotation);
    }
}
