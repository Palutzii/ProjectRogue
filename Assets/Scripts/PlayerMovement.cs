using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour{
    public float speed;

    Vector2 direction;

    void Update(){
        TakeInput();
        Move();
    }

    void Move(){
        transform.Translate(direction * (speed * Time.deltaTime));
    }

    void TakeInput(){
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W)){
            direction += Vector2.up;
        }
        
        if (Input.GetKey(KeyCode.A)){
            direction += Vector2.left;
        }
        
        if (Input.GetKey(KeyCode.S)){
            direction += Vector2.down;
        }
        
        if (Input.GetKey(KeyCode.D)){
            direction += Vector2.right;
        }
    }
}
