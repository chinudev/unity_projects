using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrength = 10;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            myRigidbody.velocity = Vector2.up * FlapStrength;
            print("Raunav is jumpy bumpy.");
        }
        // print the velocity of the bird
    }

    private void OnCollisionEnter2D(Collision2D other) { 
        logic.gameOver();
        birdIsAlive = false;
    }
}
