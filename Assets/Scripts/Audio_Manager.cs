using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
  public AudioSource backgroundMaster;
  public AudioSource pongBallNoises;

  public static Audio_Manager instance = null;
  void Awake()
  {
    if (instance == null)
    {
      instance = this;
    }
    else if (instance != this)
      Destroy(gameObject);
    DontDestroyOnLoad(gameObject);
  }
  public void PlayBackground(AudioClip soundToPlay)
  {
    backgroundMaster.clip = soundToPlay;
    backgroundMaster.Play();
  }

  public void Other(AudioClip soundToPlay)
  {
    pongBallNoises.clip = soundToPlay;
    pongBallNoises.Play();
  }
}
