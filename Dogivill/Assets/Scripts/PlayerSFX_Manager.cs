using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX_Manager : SFXManager
{
  public void PlayFootStep(){
    int choice = Random.Range(1,2);
    string name = "OnStep " + choice;
    PlaySFX(name);
  }

  public void PlayJumpSFX(){
    PlaySFX("OnJump");
  }

  public void PlayLandSFX(){
    PlaySFX("OnLand");
  }

  public void PlaySwingSFX(){
    PlaySFX("OnSwing");
    PlaySFX("OnSwing_2");
  }

  public void PlayHurtSFX(){
    PlaySFX("OnHurt");
  }
}
