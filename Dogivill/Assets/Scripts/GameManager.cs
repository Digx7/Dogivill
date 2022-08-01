using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent OnPlayerWin;

    public UnityEvent OnPlayerLose;

    public void PlayerWin(){
      OnPlayerWin.Invoke();
    }

    public void PlayerLose(){
      OnPlayerLose.Invoke();
    }
}
