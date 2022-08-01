using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth_UI : MonoBehaviour
{
    public int currentHealth;

    public List<GameObject> healthUnits;

    public void UpdateHealth(int newAmount){
      currentHealth = newAmount;
      DrawUI();
    }

    private void DrawUI(){
      for(int i=0; i < healthUnits.Count; ++i){
        if(i < currentHealth) healthUnits[i].SetActive(true);
        else healthUnits[i].SetActive(false);
      }
    }
}
