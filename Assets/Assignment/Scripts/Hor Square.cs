using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class HorSquare : MonoBehaviour
{
    Rigidbody2D rb;
    public float distance = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() 
    {
        Vector3 HorDirection = new Vector3(distance, 0, 0);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x >= -7)
            {
                transform.position = transform.position - HorDirection;
            }

        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x <= 7)
            {
                transform.position = transform.position + HorDirection;
            }

        }
    }
}
