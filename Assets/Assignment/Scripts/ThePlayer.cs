using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThePlayer : MonoBehaviour
{

    Rigidbody2D rb;
    public float distance = 2;


    Vector3 LowBoundary = new Vector3(-9, -9, 0);
    Vector3 HighBoundary = new Vector3(9, -9, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Verical");

        Vector3 HorDirection = new Vector3(2, distance, 0);
        Vector3 VertDirection = new Vector3(0, distance, 0);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //if(transform.position>) :( if transform is within the boundary.
            transform.position = transform.position - VertDirection;
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            transform.position = transform.position + VertDirection;
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            transform.position = transform.position - HorDirection;
        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            transform.position = transform.position + HorDirection;
        }



    }

}
