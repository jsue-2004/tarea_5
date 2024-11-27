using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    public float velocity;
    
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(0, velocity) ;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "muro")
        {
            Destroy(this.gameObject);
        }
    }

}
