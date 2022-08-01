using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation_Manager : MonoBehaviour
{
    public Animator animator;

    public Vector2 moveDirection;

    private bool tryAttack=false;
    private bool land=false;

    public void SetMoveDirection(Vector2 input){
      moveDirection = input;
    }

    public void SetTryAttack(bool input){
      tryAttack=input;
    }

    public void Land(){
      land=true;
    }

    public void Update(){
      animate();
    }

    private void animate(){
      if(moveDirection.x <= 0.1 && moveDirection.x >= -0.1) animator.SetBool("IsRunning", false);
      else animator.SetBool("IsRunning", true);

      if(moveDirection.y <= 0.1) animator.SetBool("IsJumping", false);
      else animator.SetBool("IsJumping", true);

      if(moveDirection.y >= -0.1) animator.SetBool("IsFalling", false);
      else animator.SetBool("IsFalling", true);

      if(tryAttack) {
        animator.SetTrigger("Attack");
        tryAttack = false;
      }

      if(land){
        animator.SetTrigger("Land");
        land=false;
      }
    }
}
