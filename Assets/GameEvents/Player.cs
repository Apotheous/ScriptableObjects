using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100;


    public UnityEvent deadEvent;
    public void DisableControls()
    {
        Debug.Log("DisableControls");
    }

    void OnMouseDown()
    {

        health -= 10;
        if (health <= 0)
        {
            Debug.Log("PlayerDead");
            deadEvent.Invoke();
        }
        // Destroy the gameObject after clicking on it
        //Destroy(gameObject);
    }
}
