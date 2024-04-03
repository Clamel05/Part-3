using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class VertSquare : Enemies
{
    Rigidbody2D rb;
    public float distance = 2; //distance that the object moves
    public float MoveDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        hit();

        Vector3 VertDirection = new Vector3(0, distance, 0);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(MoveDelayY());
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) // Using | as OR doesn't work with trans.pos and I don't know another way to connect them as an OR so I'm doing it with multiple ifs
        {
            StartCoroutine(MoveDelayY());
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(MoveDelayY());
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(MoveDelayY());
        }

        //static on all horizontal squares to reset game. Create death counter UI which increases for each death.

    }

    IEnumerator MoveDelayY()
    {
        Vector3 VertDirection = new Vector3(0, distance, 0);
        yield return new WaitForSeconds(MoveDelay);
        transform.position = transform.position - VertDirection;
        if (transform.position.y <= -7)
        {
            distance *= -1;
        }
        if (transform.position.y >= 7)
        {
            distance *= -1;
        }
    }



    protected override void hit()
    {
        base.hit();
    }
}