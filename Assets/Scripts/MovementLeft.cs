using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLeft : MonoBehaviour {
  public GameObject leftPlayer;
  public float moveSpeed;
  void Update () {
		if(Input.GetKey(KeyCode.W))
    {
      leftPlayer.transform.Translate(transform.forward * moveSpeed);
    }
    if (Input.GetKey(KeyCode.S))
    {
      leftPlayer.transform.Translate(-transform.forward * moveSpeed);
    }
    
  }
}
