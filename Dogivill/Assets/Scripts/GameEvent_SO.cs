using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewGameEvent", menuName = "ScriptableObjects/GameEvent", order = 1)]
public class GameEvent_SO : ScriptableObject
{

protected List<GameEventListener> listeners =
  new List<GameEventListener>();

public void Raise(string input = "")
{
for(int i = listeners.Count -1; i >= 0; i--)
listeners[i].OnEventRaised(input);
}

public void RegisterListener(GameEventListener listener)
{ listeners.Add(listener); }

public void UnregisterListener(GameEventListener listener)
{ listeners.Remove(listener); }
}
