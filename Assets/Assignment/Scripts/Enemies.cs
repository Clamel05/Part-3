using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemies : MonoBehaviour
{
    public static bool collide;


    // Start is called before the first frame update
    void Start()
    {
        //HorSquare.score;
    }

    private void Update()
    {
        hit();

    }

    protected virtual void hit()//Inheritance gives the hit function to the two enemy squares
    {
        if (collide == true)
        {
            collide = false;
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


            HorSquare.Scorenew(true);
        }
        
    }
    void OnTriggerEnter2D(Collider2D Collision)
    {
        collide = true;
    }

}