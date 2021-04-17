using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
    
            if (col.gameObject.tag == "enemy")
            {
                col.gameObject.GetComponent<Enemy>().Damage();

                Destroy(gameObject);
            }
        
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }

}
