using System;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 2.5f;
    
    private bool movingRight = true;
    private Rigidbody2D rb;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, 0);
        }
        else
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, 0);
        }
    }

    public void Flip()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
        movingRight = !movingRight;
    }
    
    
}
