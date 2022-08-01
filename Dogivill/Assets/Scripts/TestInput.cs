using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestInput : MonoBehaviour
{
    public FloatEvent AD;
    public UnityEvent Space;
    public GameEvent_SO DropEvent;
    public UnityEvent LeftClick;

    public void Update(){
      AD.Invoke(AD_check());
      if(Space_check()){
         Space.Invoke();
         Debug.Log("Space Bar Pressed");
       }
       if(s_check()){
         DropEvent.Raise();
       }
       if(leftClick_check()){
         LeftClick.Invoke();
       }
    }

    private float AD_check(){
      float output = 0.0f;

      if(Input.GetKey("d")) output=1;
      if(Input.GetKey("a")) output=-1;

      return output;
    }

    private bool Space_check(){
      if(Input.GetKeyDown("space")) return true;
      else return false;
    }

    private bool s_check(){
      if(Input.GetKeyDown("s")) return true;
      else return false;
    }

    private bool leftClick_check(){
      if(Input.GetKeyDown(KeyCode.Mouse0)) return true;
      else return false;
    }
}
