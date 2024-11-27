using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Animator _componentAnimation;
    public Rigidbody2D _componentRigidbody2d;
    public float velocity;
    // Start is called before the first frame update
    void Awake()
    {
        _componentAnimation = GetComponent<Animator>();
        _componentRigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (_componentAnimation.GetBool("dead")!=true)
        {
            _componentRigidbody2d.velocity = new Vector2(0, velocity);
        }
        else
        {
            _componentRigidbody2d.velocity = new Vector2(0, 0);
        }
         
    }
    private void destroyself()
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            _componentAnimation.SetBool("dead", true);
        }
        if (collision.gameObject.tag == "muro")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
