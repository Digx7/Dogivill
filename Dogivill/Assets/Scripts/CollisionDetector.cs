using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

  public string tagToWatchFor;

  public bool isOn=true;

  public Collision2DEvent OnCollisionEnter;

  public Collision2DEvent OnCollisionExit;

  public void OnCollisionEnter2D(Collision2D collision)
  {
      if (isOn && collision.gameObject.tag == tagToWatchFor)
      {
          OnCollisionEnter.Invoke(collision);
      }
  }

  public void OnCollisionExit2D(Collision2D collision)
  {
      if (isOn && collision.gameObject.tag == tagToWatchFor)
      {
          OnCollisionExit.Invoke(collision);
      }
  }
}
