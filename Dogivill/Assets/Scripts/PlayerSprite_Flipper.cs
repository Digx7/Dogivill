using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite_Flipper : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    public Transform attackManager;

    public Vector2 RightPosition;
    public Vector2 LeftPosition;

    public void Rotate(float input){
      if(input > 0){
        spriteRender.flipX = false;
        attackManager.localPosition = RightPosition;
      }
      else if(input < 0){
        spriteRender.flipX = true;
        attackManager.localPosition = LeftPosition;
      }

      // Debug.Log("PlayerSprite_Flipper Rotate(" + input + ")");
    }
}
