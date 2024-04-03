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

    }

    private void Update()
    {
        hit();
    }

    protected virtual void hit()
    {
        if (collide == true)
        {

            Debug.Log("Collide");
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void OnTriggerEnter2D(Collider2D Collision)
    {
        collide = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        collide = false;
    }




}