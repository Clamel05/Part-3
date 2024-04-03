using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class HorSquare : Enemies
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

        Vector3 HorDirection = new Vector3(distance, 0, 0);
        Vector3 LowBoundaryX = new Vector3(-9, 0, 0);
        Vector3 HighBoundaryX = new Vector3(9, 0, 0);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = transform.position - HorDirection;
            if (transform.position.x <= -7)
            {
                distance *= -1;
            }
            if (transform.position.x >= 7)
            {
                distance *= -1;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) // Using | as OR doesn't work with trans.pos and I don't know another way to connect them as an OR so I'm doing it like this
        {
            transform.position = transform.position - HorDirection;
            if (transform.position.x <= -7)
            {
                distance *= -1;
            }
            if (transform.position.x >= 7)
            {
                distance *= -1;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position - HorDirection;
            if (transform.position.x <= -7)
            {
                distance *= -1;
            }
            if (transform.position.x >= 7)
            {
                distance *= -1;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transform.position - HorDirection;
            if (transform.position.x <= -7)
            {
                distance *= -1;
            }
            if (transform.position.x >= 7)
            {
                distance *= -1;
            }
        }

        //static on all horizontal squares to reset game. Create death counter UI which increases for each death.

    }
    protected override void hit()
    {
        Debug.Log("HitStart");
        base.hit();
        Debug.Log("EndHit");
    }
}
