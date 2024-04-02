using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class HorSquare : MonoBehaviour
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

            if (transform.position.x >= 8)
            {
                distance *= 1;
            }
        }
        //static on all horizontal squares to reset game. Create death counter UI which increases for each reset.
        
    }
}
