using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlightControl : MonoBehaviour
{
    public GameObject missile;
    public float speed = 5;
    public float turningSpeedReduction = 0.75f;
    Coroutine coroutine;

    private void Start()
    {
        StartCoroutine(MoveMissile());
    }

    IEnumerator MoveMissile()
    {
        StartCoroutine(MoveForwards());
        yield return null;
    }


    public void MakeTurn(float turn)
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        coroutine = StartCoroutine(Turn(turn));
    }

    IEnumerator MoveForwards(float length)
    {
        length = 5;
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        coroutine = StartCoroutine(RunLeg(length));
        yield return null;
    }

    IEnumerator RunLeg(float legLength)
    {
        float time = 0;
        while (time < legLength)
        {
            time += Time.deltaTime;
            missile.transform.Translate(transform.right * speed * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator Turn(float turn)
    {
        float interpolation = 0;
        Quaternion currentHeading = missile.transform.rotation;
        Quaternion newHeading = currentHeading * Quaternion.Euler(0, 0, turn);
        while (interpolation < 1)
        {
            interpolation += Time.deltaTime;
            missile.transform.rotation = Quaternion.Lerp(currentHeading, newHeading, interpolation);
            missile.transform.Translate(transform.right * (speed * turningSpeedReduction) * Time.deltaTime);
            yield return null;
        }
    }
}
