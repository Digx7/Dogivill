using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Actions : MonoBehaviour
{
    public GameData_Vector2_SO playerPos;

    public Movement movement;

    private bool moveTowardsPlayer=false;
    private float lastPlayerDirection=0.0f;

    public void Update(){
      if(moveTowardsPlayer)movement.SetMoveDirection(lastPlayerDirection);
    }

    public void OnJumpStart(){
      movement._Jump();
      Start_MovingTowardsPlayer();
      lastPlayerDirection = GetDirectionTowardsPlayer();
    }

    public void OnJumpEnd(){
      Stop_MovingTowardsPlayer();
    }

    public void Start_MovingTowardsPlayer(){
      moveTowardsPlayer=true;
    }

    public void Stop_MovingTowardsPlayer(){
      moveTowardsPlayer=false;
      movement.SetMoveDirection(0.0f);
    }

    private float GetDirectionTowardsPlayer(){
      if(playerPos.GetData().x > this.transform.position.x) return 1.0f;
      if(playerPos.GetData().x < this.transform.position.x) return -1.0f;
      else return 0.0f;
    }
}
