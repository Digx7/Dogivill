using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public bool isInvinvible = false;
    public bool haveIFrames = false;
    public float iFramesLength = 0.0f;

    public IntEvent OnHealthChange;
    public UnityEvent OnDeath;

    public void TakeDamage(int amount){
      if(!isInvinvible){
        currentHealth -= amount;
        OnHealthChange.Invoke(currentHealth);
        CheckIsDead();
        if(haveIFrames) StartCoroutine(IFrames());
      }
    }

    public void Heal(int amount){
      if(!isInvinvible){
        currentHealth += amount;
        OnHealthChange.Invoke(currentHealth);
        CheckIsDead();
        if(haveIFrames) StartCoroutine(IFrames());
      }
    }

    private void CheckIsDead(){
      if(currentHealth <= 0) OnDeath.Invoke();
    }

    IEnumerator IFrames(){
      isInvinvible = true;
      yield return new WaitForSeconds(iFramesLength);
      isInvinvible = false;
    }
}
