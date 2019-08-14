using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 3;
    private int direction = 1;


    // Update is called once per frame
    void FixedUpdate()
    {
        Move(1);
        
    }

    void Move(int dir)
    {
        Vector3 movement = transform.forward * dir * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    private void OnCollisionEnter(Collision coll)
    {
        ContactPoint contact;
        if (coll.gameObject.name.Contains("Wall"))
        {
            contact = coll.contacts[0];

 
            rb.velocity = Vector3.Reflect(transform.forward, contact.normal);
        }
    }


}
