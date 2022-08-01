using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtBox : MonoBehaviour
{
    public int attackAmount;

    public void SetTime(float time){
      StartCoroutine(LifeTime(time));
    }

    IEnumerator LifeTime(float time){
      yield return new WaitForSeconds(time);
      Destroy(gameObject);
    }
}
