using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
  public GameEvent_SO Event;
  public StringEvent Response;
  public IntEvent Response_Int;

  private void OnEnable()
  { Event.RegisterListener(this); }

  private void OnDisable()
  { Event.UnregisterListener(this); }

  public void OnEventRaised(string input = "")
  { Response.Invoke(input); }

  public void OnEventRaised(int input = 0)
  { Response_Int.Invoke(input); }
}
