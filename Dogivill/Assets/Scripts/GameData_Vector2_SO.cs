using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewGameData_Vector2", menuName = "ScriptableObjects/GameData/Vector2", order = 1)]
public class GameData_Vector2_SO : ScriptableObject
{
    public Vector2 data;

    public Vector2 GetData(){
      return data;
    }

    public void SetData(Vector2 input){
      data = input;
    }
}
