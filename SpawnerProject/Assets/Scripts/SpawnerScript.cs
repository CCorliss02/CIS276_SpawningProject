using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject ballPrefab;
    public float timeToWait = 3f;

    IEnumerator SpawnObjectAfterTime(float secondsToWait)
    {
        yield return new WaitForSeconds(secondsToWait);
        GameObject ball;
        ball = Instantiate(ballPrefab, transform);

        ball.GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }

    void Update()
    {
        // Press F to fire.
        if(Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(SpawnObjectAfterTime(timeToWait));
        }
    }
}