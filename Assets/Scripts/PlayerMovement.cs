using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour{
    
    public float speed;

    Animator _animator;
    Vector2 direction;

    void Awake(){
        _animator = GetComponent<Animator>();
    }

    void Update(){
        TakeInput();
        Move();
    }

    void Move(){
        transform.Translate(direction * (speed * Time.deltaTime));
        SetAnimatorMovement(direction);
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

    void SetAnimatorMovement(Vector2 direction){
        _animator.SetFloat("xDir", direction.x);
        _animator.SetFloat("yDir", direction.y);
    }
}

