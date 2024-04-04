using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemies : MonoBehaviour
{
    public static bool collide;
    public Enemies enemy;

    // Start is called before the first frame update
    void Start()
    {

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
            int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
            SceneManager.LoadScene(nextSceneIndex);


            HorSquare.Scorenew(enemy);//part of the static in HorSquare script
        }
        
    }
    void OnTriggerEnter2D(Collider2D Collision)
    {
        collide = true;
    }

}