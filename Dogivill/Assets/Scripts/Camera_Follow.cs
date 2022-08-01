using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public GameData_Vector2_SO target;
    public Vector2 boundaries;

    private Vector3 newPosition;

    public void LateUpdate(){
      newPosition = this.transform.position;

      newPosition.x = target.GetData().x;
      if(newPosition.x < boundaries.x) newPosition.x = boundaries.x;
      else if(newPosition.x > boundaries.y) newPosition.x = boundaries.y;

      this.transform.position = newPosition;
    }
}
