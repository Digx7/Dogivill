using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public BoolEvent isCollisionOn;

    public bool playerIsTouching;

    public void Drop(){
      if(playerIsTouching){
        isCollisionOn.Invoke(false);
        //playerIsTouching=false;
      }
    }

    public void Reset(){
      isCollisionOn.Invoke(true);
    }

    public void SetPlayerIsTouching(bool input){
      playerIsTouching = input;
    }
}
