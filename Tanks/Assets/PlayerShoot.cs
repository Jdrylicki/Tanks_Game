using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{ 
    public Transform bulletPos;
    public GameObject bullet;
    
     

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnLoation = bulletPos.position + (bulletPos.forward/2);
        if (Input.GetMouseButtonDown(0))
            Instantiate(bullet, spawnLoation, bulletPos.rotation);
        
    }
    
}
