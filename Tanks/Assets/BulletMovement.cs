using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 3;
    public int numRicochet = 2;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        bulletRicochet(transform.position, transform.forward);

    }
  
    void bulletRicochet(Vector3 pos, Vector3 dir)
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + .05f))
        {
            if (hit.collider.gameObject.name.Contains("Wall") && numRicochet > 0)
            {
                Vector3 reflection = Vector3.Reflect(ray.direction, hit.normal);
                float rot = 90 - Mathf.Atan2(reflection.z, reflection.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0, rot, 0);
                numRicochet--;
            }
            else if(numRicochet <= 0)
                Destroy(this.gameObject);

            if (hit.collider.gameObject.name.Contains("Player"))
            {
                Destroy(this.gameObject);
                Destroy(hit.collider.gameObject);
            }
        }
    }


}
