using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Brain : MonoBehaviour
{
    public Animator animator;

    public float waitTime;

    public void Start(){
      StartCoroutine(Timer());
    }

    IEnumerator Timer(){
      yield return new WaitForSeconds(waitTime);
      Jump();
    }

    public void Jump(){
      animator.SetTrigger("Jump");
      StartCoroutine(Timer());
    }
}
