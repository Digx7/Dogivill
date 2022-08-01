using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Attack_Manager : MonoBehaviour
{
    public bool isAttackGoing = false;
    public bool isCancelable = false;

    public GameObject hurtBoxPrefab;

    public float windUpTime = 0.0f;
    public float attackTime = 0.0f;
    public float followThroughTime = 0.0f;

    public UnityEvent OnAttackStart;
    public UnityEvent OnAttackEnd;
    public UnityEvent OnAttackCancel;

    public GameObject hurtBoxInstance;

    public void StartAttack(){
      if(!isAttackGoing){
        StartCoroutine(WindUp(windUpTime));
      }
    }

    public void CancleAttack(){
      if(isCancelable && isAttackGoing){
        //cancle attack
      }
    }

    IEnumerator WindUp(float time){
      isAttackGoing = true;
      OnAttackStart.Invoke();
      yield return new WaitForSeconds(time);
      StartCoroutine(Attack(attackTime));
    }

    IEnumerator Attack(float time){
      hurtBoxInstance = Instantiate(hurtBoxPrefab, this.transform.position  , Quaternion.identity);
      hurtBoxInstance.GetComponent<HurtBox>().SetTime(time);
      yield return new WaitForSeconds(time);
      StartCoroutine(FollowThrough(followThroughTime));
    }

    IEnumerator FollowThrough(float time){
      yield return new WaitForSeconds(time);
      OnAttackEnd.Invoke();
      isAttackGoing = false;
    }
}
