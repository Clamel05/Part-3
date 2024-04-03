using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThePlayer : MonoBehaviour
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
        Debug.Log(Enemies.collide);
        //horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Verical");

        Vector3 HorDirection = new Vector3(distance, 0, 0);
        Vector3 VertDirection = new Vector3(0, distance, 0);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(transform.position.y >= -7)
            {
                transform.position = transform.position - VertDirection;
            }
            
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.y <= 7)
            {
                transform.position = transform.position + VertDirection;
            }
        }


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
