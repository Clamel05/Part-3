using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class VertTriangle : Enemies
{
    Rigidbody2D rb;
    public float distance = 2; //distance that the object moves

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        hit();

        Vector3 VertDirection = new Vector3(distance, distance, 0);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = transform.position + VertDirection;
            if (transform.position.y <= -7)
            {
                distance *= -1;
            }
            if (transform.position.y >= 7)
            {
                distance *= -1;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) // Using | as OR doesn't work with trans.pos and I don't know another way to connect them as an OR so I'm doing it like this
        {
            transform.position = transform.position + VertDirection;
            if (transform.position.y <= -7)
            {
                distance *= -1;
            }
            if (transform.position.y >= 7)
            {
                distance *= -1;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position + VertDirection;
            if (transform.position.y <= -7)
            {
                distance *= -1;
            }
            if (transform.position.y >= 7)
            {
                distance *= -1;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transform.position + VertDirection;
            if (transform.position.y <= -7)
            {
                distance *= -1;
            }
            if (transform.position.y >= 7)
            {
                distance *= -1;
            }
        }

        //static on all horizontal squares to reset game. Create death counter UI which increases for each death.

    }
    protected override void hit()
    {
        base.hit();
    }
}