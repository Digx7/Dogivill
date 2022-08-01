using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MusicManager : MonoBehaviour
{
  public static MusicManager Instance { get; private set; }

  public List<Song> songs;
  public float switchSpeed;
  public int currentSong;

  public TextMeshProUGUI songNameField;
  public TextMeshProUGUI songArtistField;
  public Animator animator;

  private void Awake()
  {
    // If there is an instance, and it's not me, delete myself.

    if (Instance != null && Instance != this)
    {
        Destroy(this.gameObject);
    }
    else
    {
        Instance = this;
    }

    DontDestroyOnLoad(this);
    currentSong = 101;

    SceneManager.activeSceneChanged += ChangedActiveScene;
  }

  public void Play(){
    songs[currentSong].source.Play();
  }

  public void Play(int input){
    songs[input].source.Play();
    currentSong = input;
  }

  public void Stop(){
    songs[currentSong].source.Stop();
  }

  private void Stop(int input){
    songs[input].source.Stop();
  }

  public void Transition(int input){
    if(input != currentSong && input < songs.Count){
      if(currentSong < songs.Count)StartCoroutine(_FadeOut(currentSong));
      StartCoroutine(_FadeIn(input));
      currentSong = input;
      NewSongAnimation();
    }
  }

  private void NewSongAnimation(){
    if(animator != null){
      if(songNameField != null) songNameField.text = songs[currentSong].songName;
      if(songArtistField != null) songArtistField.text = songs[currentSong].songArtist;

      animator.SetTrigger("New Song");
    }
  }

  private void ChangedActiveScene(Scene current, Scene next)
    {
        string currentName = current.name;

        if (currentName == null)
        {
            // Scene1 has been removed
            currentName = "Replaced";
        }

        //Debug.Log("Scenes: " + currentName + ", " + next.name);

        for(int i =0; i< songs.Count; ++i){
          if(songs[i].trigger == next.name){
            Transition(i);
          }
        }

    }

  private void FadeOut(int index){
    StartCoroutine(_FadeOut(index));
  }

  private void FadeIn(int index){
    StartCoroutine(_FadeOut(index));
  }

  IEnumerator _FadeOut(int index){
    while(songs[index].source.volume != 0){
      songs[index].source.volume -= switchSpeed * Time.deltaTime;
      yield return null;
    }
    Stop(index);
  }

  IEnumerator _FadeIn(int index){
    Play(index);
    while(songs[index].source.volume != 1){
      songs[index].source.volume += switchSpeed * Time.deltaTime;
      yield return null;
    }
  }


}
