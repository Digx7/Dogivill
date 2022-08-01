using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewGameEvent_Int", menuName = "ScriptableObjects/GameEvents/Int", order = 1)]
public class GameEvent_Int_SO : GameEvent_SO
{
  public void Raise(int input){
    for(int i = listeners.Count -1; i >= 0; i--)
    listeners[i].OnEventRaised(input);
  }
}
