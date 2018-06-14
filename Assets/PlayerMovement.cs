﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;
    public float forwardForse = 2000f;
    public float sidewayForse = 500f;

    void FixedUpdate() {
        rigidBody.AddForce(0, 0, forwardForse * Time.deltaTime);

        if (Input.GetKey("d")) {
            rigidBody.AddForce(sidewayForse * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) {
            rigidBody.AddForce(-sidewayForse * Time.deltaTime, 0, 0);
        }
    }
}
