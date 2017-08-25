using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRight : MonoBehaviour {
  public GameObject rightPlayer;
  public float moveSpeed;
	void Update () {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      rightPlayer.transform.Translate(transform.forward * moveSpeed);
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      rightPlayer.transform.Translate(-transform.forward * moveSpeed);
    }
  }
}
