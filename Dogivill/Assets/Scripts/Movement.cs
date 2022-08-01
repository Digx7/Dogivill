using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveDirection;
    public float acceleration;
    public float maxSpeed;
    public Vector2 deadZone;

    public bool tryJump;
    public float jumpForce;
    public float fallAcceleration;
    public float maxFallSpeed;

    public Rigidbody2D rb;

    public bool isTouchingGround=true;

    public Vector2Event OnVelocityChange;
    public FloatEvent LastXDirection;
    public Vector2Event OnPositionChange;

    public void SetMoveDirection(float input){
      moveDirection = input;
    }

    public void SetMoveDirection(Vector2 input){
      moveDirection = input.x;
    }

    public void _Jump(){
      tryJump = true;
    }

    public void SetIsTouchingGround(bool input){
      isTouchingGround = input;
    }

    public void FixedUpdate(){
      MoveLeftRight();
      if(tryJump) Jump();
      if(rb.velocity.y < 0 && rb.velocity.y > -maxFallSpeed) Fall();

      SetVelocityVisable();
      SetLastXDirection();
      BroadcastNewPosition();
    }

    private void MoveLeftRight(){
      if(moveDirection > deadZone.x || moveDirection < -deadZone.x){
        Vector2 direction = new Vector2(moveDirection * acceleration, 0);
        if(rb.velocity.x < maxSpeed && rb.velocity.x > -maxSpeed) {
          rb.AddForce(direction);
          //Debug.Log("Moving Left Right");
        }
      }
    }

    private void Jump(){
      tryJump = false;
      if(isTouchingGround){
        isTouchingGround = false;
        Vector2 jumpVector = new Vector2(0,jumpForce);
        rb.AddForce(jumpVector);
      }
    }

    private void Fall(){
      Vector2 direction = new Vector2(0, -1 * fallAcceleration);
      rb.AddForce(direction);
    }

    private void SetVelocityVisable(){
      OnVelocityChange.Invoke(rb.velocity);
    }

    private void SetLastXDirection(){
      if(moveDirection > 0.1 || moveDirection < -0.1) LastXDirection.Invoke(moveDirection);
    }

    private void BroadcastNewPosition(){
      OnPositionChange.Invoke(this.transform.position);
    }
}
