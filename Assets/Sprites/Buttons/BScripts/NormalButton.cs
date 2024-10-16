using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NormalButton : MonoBehaviour
{
  [SerializeField] private Sprite[] buttonImage;
private TopaccaBallsPoints _TBP;
public AudioSource audioClip;

public int points;

private void Awake()
{
  _TBP = FindObjectOfType<TopaccaBallsPoints>();
}

public void onClick()
  {
   StartCoroutine(ChangeImage());
   _TBP.AddPoints(points);
    audioClip.PlayOneShot(audioClip.clip);
  }


  IEnumerator ChangeImage()
 {
  GetComponent<Image>().sprite = buttonImage[1];
  yield return new WaitForSeconds(1f/5f);
  GetComponent<Image>().sprite = buttonImage[0];

 }
}
