using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int enemyHealth = 5;

    public void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "cannonball")
        {
            enemyHealth--;
            Debug.Log("The enemy's health is now " + enemyHealth + ".");
        }

        if (enemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void Awake()
    {
        Debug.Log("Press F to fire the cannon.");
    }
}
