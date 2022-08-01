using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSFX_Manager : SFXManager
{
    public void PlayJumpSFX(){
      PlaySFX("OnJump");
    }

    public void PlayLandSFX(){
      PlaySFX("OnLand");
    }

    public void PlayHurtSFX(){
      PlaySFX("OnHurt");
    }
}
