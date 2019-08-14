using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distruction : MonoBehaviour
{
    float lifeSpan = 10f;

    // Update is called once per frame
    void Update()
    {
        if (lifeSpan > 0)
            lifeSpan -= Time.deltaTime;
        if (lifeSpan <= 0)
            Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name.Contains("Player"))
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }
        
    }
}
