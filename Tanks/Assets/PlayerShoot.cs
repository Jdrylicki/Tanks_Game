using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{ 
    public Transform turretPos;
    public GameObject bullet;
 
     

    // Update is called once per frame
    void Update()
    {

        Vector3 spawnLoation = turretPos.position;
        if (Input.GetMouseButtonDown(0))
            Instantiate(bullet, spawnLoation, turretPos.rotation);
        
    }
    
}
