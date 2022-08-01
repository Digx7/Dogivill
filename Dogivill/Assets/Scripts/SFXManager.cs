using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public List<AudioSource> SFXs;

    public void Start(){
      GetComponentsInChildren<AudioSource>(true, SFXs);
    }

    public void PlaySFX(string name){
      foreach(AudioSource source in SFXs){
        if(source.gameObject.name == name) {
          source.Play();
          return;
        }
      }
      Debug.LogWarning("Tried to play nonexistant SFX: " + name);
    }
}
